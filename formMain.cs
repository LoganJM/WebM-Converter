using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MasterOfWebM
{
    public partial class formMain : Form
    {
        private String THREADS = Environment.ProcessorCount.ToString();             // Obtains the number of threads the computer has
        private String runningDirectory = AppDomain.CurrentDomain.BaseDirectory;    // Obtains the root directory

        private Regex verifyLength = new Regex(@"^\d{1,3}");                                // Regex to verify if txtLength is properly typed in
        private Regex verifyTimeStart = new Regex(@"^[0-6]\d:[0-6]\d:[0-6]\d");             // Regex to verify if txtStartTime is properly typed in
        private Regex verifyWidth = new Regex(@"^\d{1,4}");                                 // Regex to verify if txtWidth is properly typed in
        private Regex verifyMaxSize = new Regex(@"^\d{1,4}");                               // Regex to verify if txtMaxSize is properly typed in

        public formMain()
        {
            InitializeComponent();
        }

        // As soon as the user clicks on txtTimeStart, get rid of the informational text
        private void SetControlTextActiveStyle(TextBox control, object sender, EventArgs e, string defaultText)
        {
            if (control.Text == defaultText)
            {
                control.Text = "";
                control.ForeColor = Color.Black;
            }

        }

        // Check if the user clicks away without typing anything into txtTimeStart
        private void SetControlTextInactiveStyle(TextBox control, object sender, EventArgs e, string defaultText)
        {
            if (control.Text == "")
            {
                control.Text = defaultText;
                control.ForeColor = Color.Silver;
            }
        }

        private bool isValidStartTime(string timeString)
        {
            if(verifyTimeStart.IsMatch(timeString))
            {
                foreach (string timeChunk in timeString.Split(':'))
                {
                    if(Convert.ToInt32(timeChunk) > 60)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private string convertTimeChunk(string chunk, string defaultText)
        {
            if (chunk == defaultText)
            {
                return "00";
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(chunk);
                    return num.ToString("D2");
                }
                catch (System.Exception)
                {
                    return "??";
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Set up a time string variable for this scope
            string givenStartTime = convertTimeChunk(txtTimeStartHour.Text, "HH")
                                  + ":"
                                  + convertTimeChunk(txtTimeStartMinute.Text, "MM")
                                  + ":"
                                  + convertTimeChunk(txtTimeStartSecond.Text, "SS");

            // Find subtitle extension
            string subtitleExtension = (txtSubs.Text != "") ? Path.GetExtension(txtSubs.Text) : "";

            // Delete any existing temp subtitle file
            Helper.subsCheck();

            // Disable btnConvert so user's cant click on it multiple times
            btnConvert.Enabled = false;

            // Base command where each element gets replaced
            String baseCommand = "-y {time1} -i \"{input}\" {time2} -t {length} -c:v libvpx -b:v {bitrate} {scale} -threads {threads} {quality} {audio} ";
            String filterCommands = null;

            // Verification boolean just in case the user messes up
            bool ErrorRaised = false;
            bool filters = false;

            double bitrate = 0;

            // Validates input file.
            if (!File.Exists(txtInput.Text) && txtInput.Text != "")
            {
                ErrorRaised = true;
                MessageBox.Show("Given input file does not exist.", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtInput.Text == "")
            {
                ErrorRaised = true;
                MessageBox.Show("An input file needs to be selected", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baseCommand = baseCommand.Replace("{input}", txtInput.Text);
            }

            // Validates if the user input a value for txtOutput
            if (txtOutput.Text == "")
            {
                ErrorRaised = true;
                MessageBox.Show("An output file destination needs to be given.", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Validates txtTimeStart input text fields
            if (!isValidStartTime(givenStartTime))
            {
                ErrorRaised = true;
                MessageBox.Show($"The time format \"{givenStartTime}\" is invalid.", "Verification Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double secondsIntoVideo = Helper.convertToSeconds(givenStartTime);

                if (secondsIntoVideo > 30)
                {
                    if (txtSubs.Text == "")
                    {
                        // If no subtitles selected
                        baseCommand = baseCommand.Replace("{time1}", "-ss " + Convert.ToString(secondsIntoVideo - 30));
                        baseCommand = baseCommand.Replace("{time2}", "-ss 30");
                    }
                    else
                    {
                        // If subtitles exist
                        baseCommand = baseCommand.Replace(" {time1}", "");
                        baseCommand = baseCommand.Replace("{time2}", "-ss " + Convert.ToString(secondsIntoVideo));
                    }
                }
                else
                {
                    baseCommand = baseCommand.Replace(" {time1}", "");
                    baseCommand = baseCommand.Replace("{time2}", "-ss " + secondsIntoVideo);
                }
            }

            // Validates if the user input a valid value for txtLength
            if (!verifyLength.IsMatch(txtLength.Text))
            {
                ErrorRaised = true;
                MessageBox.Show("The length of the video is not properly set. (>1 and <300)", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baseCommand = baseCommand.Replace("{length}", txtLength.Text);
            }

            // Check if we need to add subtitles
            if (txtSubs.Text != "")
            {
                if (!File.Exists(txtSubs.Text))
                {
                    ErrorRaised = true;
                    MessageBox.Show($"The given subtitle path \"{txtSubs.Text}\" does not exist.", "Verification Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    switch (subtitleExtension)
                    {
                        case ".ass":
                            filters = true;
                            File.Copy(txtSubs.Text, runningDirectory + "subs.ass");
                            filterCommands += (filterCommands == null) ? "ass=subs.ass" : ",ass=subs.ass";
                            break;
                        case ".srt":
                            filters = true;
                            File.Copy(txtSubs.Text, runningDirectory + "subs.srt");
                            filterCommands += (filterCommands == null) ? "subtitles=subs.srt" : ",subtitles=subs.srt";
                            break;
                        default:
                            filters = true;
                            // HACK: Due to the limitations of FFPMEPG, it seems this is the only viable solution. 
                            File.Copy(txtSubs.Text, runningDirectory + "video.mkv");
                            filterCommands += (filterCommands == null) ? $"subtitles=video{subtitleExtension}" : $",subtitles=video{subtitleExtension}";
                            break;
                    }
                }
            }

            // Validates if the user input a value for txtWidth
            if (!verifyWidth.IsMatch(txtWidth.Text))
            {
                ErrorRaised = true;
                MessageBox.Show("The width is not properly set. \n(Should be over 1, under 9999)", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                filters = true;
                int givenWidth = Convert.ToInt32(txtWidth.Text);
                if (givenWidth % 16 != 0)
                {
                    string warnMessage = $"Your given frame width {txtWidth.Text}px is not a common factor of the 16:9 resolution."
                    + " Some common choices for clips include:\n\n   960 x 540\n   1280 x 720\n   1600 x 900\n\nSelecting a common"
                    + " factor of 16:9 or a value divisible by 8 will help prevent scaling artifacts such as green borders from"
                    + " forming during encoding. Do you want to continue with this width?";

                    DialogResult widthWarnResult = MessageBox.Show(warnMessage, caption: "Width Warning",
                                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (widthWarnResult != DialogResult.Yes)
                    {
                        ErrorRaised = true;
                    }
                }
                filterCommands += (filterCommands == null) ? $"scale={txtWidth.Text}:-1" : $",scale={txtWidth.Text}:-1";
            }

            // Validates if the user input a value for txtMaxSize
            if (!verifyMaxSize.IsMatch(txtMaxSize.Text))
            {
                ErrorRaised = true;
                if (ErrorRaised)MessageBox.Show("The maxium file size is not properly set", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bitrate = Helper.calcBitrate(txtMaxSize.Text, txtLength.Text);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                // If audio is requested
                if (checkAudio.Checked)
                {
                    // TODO: (old) Give bitrate options for audio (currently enforcing 48k)
                    // TODO: (old) Disable audio encoding on first pass to speed up encoding
                    bitrate -= 48;
                    baseCommand = baseCommand.Replace("{audio}", "-c:a libvorbis -b:a 48k");
                }
                else
                {
                    baseCommand = baseCommand.Replace("{audio}", "-an");
                }

                // Changes the quality to what the user selected
                switch (comboQuality.Text)
                {
                    case "Good":
                        baseCommand = baseCommand.Replace("{quality}", "-quality good -cpu-used 0");
                        baseCommand = baseCommand.Replace("{bitrate}", bitrate.ToString() + "K");
                        break;
                    case "Best":
                        baseCommand = baseCommand.Replace("{quality}", "-quality best -auto-alt-ref 1 -lag-in-frames 16 -slices 8");
                        baseCommand = baseCommand.Replace("{bitrate}", bitrate.ToString() + "K");
                        break;
                    case "Iterate":
                        baseCommand = baseCommand.Replace("{quality}", "-quality best -auto-alt-ref 1 -lag-in-frames 16 -slices 8");
                        bitrate = Convert.ToDouble(bitrate) * 1024;
                        baseCommand = baseCommand.Replace("{bitrate}", bitrate.ToString());
                        break;
                }
            }

            // If any filters are being used, add them to baseCommand
            if (filters)
            {
                filterCommands = "-vf " + filterCommands;
                baseCommand = baseCommand.Replace("{scale}", filterCommands);
            }
            else
            {
                baseCommand = baseCommand.Replace(" {scale}", "");
            }

            // If everything is valid, continue with the conversion
            if (!ErrorRaised)
            {
                baseCommand = baseCommand.Replace("{threads}", THREADS);

                try
                {
                    Helper.encodeVideo(baseCommand, txtOutput.Text);
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show("You may not have ffmpeg installed. Please go\n"+
                                    "obtain a copy of it, and put it in the same folder\n"+
                                    "as this executable, or add the executable to your PATH\n"+
                                    "environment variable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(ex);
                }

                double fileSize = Helper.getFileSize(txtOutput.Text);

                if (fileSize < Convert.ToDouble(txtMaxSize.Text) * 1024)
                {
                    // Clears the output box so user's don't overwrite their previous output
                    txtOutput.Text = "";
                    if (txtSubs.Text != "")
                    {
                        switch (subtitleExtension)
                        {
                            case ".ass":
                                File.Delete(runningDirectory + "subs.ass");
                                break;
                            case ".srt":
                                File.Delete(runningDirectory + "subs.srt");
                                break;
                            default:
                                File.Delete(runningDirectory + $"video{subtitleExtension}");
                                break;
                        }
                        txtSubs.Text = "";
                    }
                }
                else
                {
                    if (comboQuality.Text == "Iterate")
                    {
                        /*
                         * Automatically attempt to create a smaller file
                         * If it doesn't work within 10 attempts, recommend
                         * 'Best' quality
                         */
                        int passes = 0;

                        while (fileSize > Convert.ToDouble(txtMaxSize.Text) * 1024 && passes <= 5)
                        {
                            // Lowers the bitrate by 2k
                            bitrate -= 2000;

                            // Replacing the whole command just in case the file name contains the same numbers
                            baseCommand = baseCommand.Replace("-b:v " + (bitrate + 1000), "-b:v " + bitrate);

                            Helper.encodeVideo(baseCommand, txtOutput.Text);
                            passes++;

                            // Gets the filesize after encoding
                            fileSize = Helper.getFileSize(txtOutput.Text);
                        }

                        if (fileSize < Convert.ToDouble(txtMaxSize.Text) * 1024)
                        {
                            txtOutput.Text = "";

                            if (txtSubs.Text != "")
                            {
                                switch (subtitleExtension)
                                {
                                    case ".ass":
                                        File.Delete(runningDirectory + "subs.ass");
                                        break;
                                    case ".srt":
                                        File.Delete(runningDirectory + "subs.srt");
                                        break;
                                    default:
                                        File.Delete(runningDirectory + $"video{subtitleExtension}");
                                        break;
                                }
                                txtSubs.Text = "";
                            }
                        }
                        else
                            MessageBox.Show("Could not hit the file size target of " + txtMaxSize.Text + "MB.\n" +
                                "Try using 'Best' quality, and if that doesn't work,\n" +
                                "you must reduce your resolution and/or shorten the length.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("The final clip is larger than " + txtMaxSize.Text + "MB.\n" +
                            "This occured because the clip's resolution was too large,\n" +
                            "and/or because the clip was too long for the inputted size.");
                    }
                }
            }

            // Re-enable the button after a run
            btnConvert.Enabled = true;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = inputFileDialog.FileName;
            }

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = saveFileDialog1.FileName;
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lblThreads.Text = "Threads: " + THREADS;
            comboQuality.SelectedIndex = 0;

            // Calls the font config checker, and if something went wrong, it disables converting
            if (!Helper.checkFFmpegFontConfig())
            {
                btnConvert.Enabled = false;
            }

            //TODO: Bind this method to my XML manifest
            // Helper.checkUpdate();
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            if (subsFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSubs.Text = subsFileDialog.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtOutput.Text = txtSubs.Text = txtLength.Text = txtWidth.Text = "";
            txtTimeStartHour.Text = "HH";
            txtTimeStartHour.ForeColor = Color.Silver;
            txtTimeStartMinute.Text = "MM";
            txtTimeStartMinute.ForeColor = Color.Silver;
            txtTimeStartSecond.Text = "SS";
            txtTimeStartSecond.ForeColor = Color.Silver;
            txtMaxSize.Text = "3.8";
            comboQuality.SelectedIndex = 0;
            checkAudio.Checked = false;
        }

        private void comboQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboQuality.Text == "Iterate")
                MessageBox.Show("\"Iterate\" will try getting just under your\n" +
                                "'Max Size'. This program will run ffmpeg up to 5 times.\n",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTimeStartHour_Enter(object sender, EventArgs e)
        {
            SetControlTextActiveStyle(txtTimeStartHour, sender, e, "HH");
        }

        private void txtTimeStartHour_Leave(object sender, EventArgs e)
        {
            SetControlTextInactiveStyle(txtTimeStartHour, sender, e, "HH");
        }

        private void txtTimeStartMinute_Enter(object sender, EventArgs e)
        {
            SetControlTextActiveStyle(txtTimeStartMinute, sender, e, "MM");
        }

        private void txtTimeStartMinute_Leave(object sender, EventArgs e)
        {
            SetControlTextInactiveStyle(txtTimeStartMinute, sender, e, "MM");
        }

        private void txtTimeStartSecond_Enter(object sender, EventArgs e)
        {
            SetControlTextActiveStyle(txtTimeStartSecond, sender, e, "SS");
        }

        private void txtTimeStartSecond_Leave(object sender, EventArgs e)
        {
            SetControlTextInactiveStyle(txtTimeStartSecond, sender, e, "SS");
        }
    }
}
