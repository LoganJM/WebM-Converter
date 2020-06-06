namespace MasterOfWebM
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblThreads = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboQuality = new System.Windows.Forms.ComboBox();
            this.btnSubs = new System.Windows.Forms.Button();
            this.txtSubs = new System.Windows.Forms.TextBox();
            this.subsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkAudio = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTimeStartSecond = new System.Windows.Forms.TextBox();
            this.txtTimeStartMinute = new System.Windows.Forms.TextBox();
            this.txtTimeStartHour = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(11, 36);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(11, 10);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(92, 39);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(329, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(92, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(329, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(76, 169);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(79, 20);
            this.txtWidth.TabIndex = 10;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(76, 137);
            this.txtLength.MaxLength = 3;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(79, 20);
            this.txtLength.TabIndex = 9;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time Start:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(346, 107);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // inputFileDialog
            // 
            this.inputFileDialog.Filter = "Video Files (*.mp4,*.mkv,*.avi)|*.mp4;*.mkv;*.avi|All Files (*.*)|*.*";
            this.inputFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "webm";
            this.saveFileDialog1.FileName = "out.webm";
            this.saveFileDialog1.Filter = "WebM File (*.webm)|*.webm";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThreads});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(437, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblThreads
            // 
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(51, 17);
            this.lblThreads.Text = "Threads:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Max Size:";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaxSize.Location = new System.Drawing.Point(233, 107);
            this.txtMaxSize.MaxLength = 4;
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(79, 20);
            this.txtMaxSize.TabIndex = 11;
            this.txtMaxSize.Text = "3.8";
            this.txtMaxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quality:";
            // 
            // comboQuality
            // 
            this.comboQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuality.FormattingEnabled = true;
            this.comboQuality.Items.AddRange(new object[] {
            "Good",
            "Best",
            "Iterate"});
            this.comboQuality.Location = new System.Drawing.Point(233, 137);
            this.comboQuality.Name = "comboQuality";
            this.comboQuality.Size = new System.Drawing.Size(79, 21);
            this.comboQuality.TabIndex = 12;
            this.comboQuality.SelectedIndexChanged += new System.EventHandler(this.comboQuality_SelectedIndexChanged);
            // 
            // btnSubs
            // 
            this.btnSubs.Location = new System.Drawing.Point(11, 62);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(75, 23);
            this.btnSubs.TabIndex = 4;
            this.btnSubs.Text = "Subtitle";
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // txtSubs
            // 
            this.txtSubs.Location = new System.Drawing.Point(92, 64);
            this.txtSubs.Name = "txtSubs";
            this.txtSubs.Size = new System.Drawing.Size(329, 20);
            this.txtSubs.TabIndex = 5;
            // 
            // subsFileDialog
            // 
            this.subsFileDialog.Filter = "SubStation Alpha Subtitles (*.ass)|*.ass|SubRip Text (*.srt)|*.srt";
            this.subsFileDialog.RestoreDirectory = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(346, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Audio:";
            // 
            // checkAudio
            // 
            this.checkAudio.AutoSize = true;
            this.checkAudio.Location = new System.Drawing.Point(265, 172);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(15, 14);
            this.checkAudio.TabIndex = 13;
            this.checkAudio.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTimeStartSecond
            // 
            this.txtTimeStartSecond.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeStartSecond.Location = new System.Drawing.Point(131, 107);
            this.txtTimeStartSecond.Name = "txtTimeStartSecond";
            this.txtTimeStartSecond.Size = new System.Drawing.Size(24, 20);
            this.txtTimeStartSecond.TabIndex = 8;
            this.txtTimeStartSecond.Text = "SS";
            this.txtTimeStartSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeStartSecond.Enter += new System.EventHandler(this.txtTimeStartSecond_Enter);
            this.txtTimeStartSecond.Leave += new System.EventHandler(this.txtTimeStartSecond_Leave);
            // 
            // txtTimeStartMinute
            // 
            this.txtTimeStartMinute.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeStartMinute.Location = new System.Drawing.Point(103, 107);
            this.txtTimeStartMinute.Name = "txtTimeStartMinute";
            this.txtTimeStartMinute.Size = new System.Drawing.Size(24, 20);
            this.txtTimeStartMinute.TabIndex = 7;
            this.txtTimeStartMinute.Text = "MM";
            this.txtTimeStartMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeStartMinute.Enter += new System.EventHandler(this.txtTimeStartMinute_Enter);
            this.txtTimeStartMinute.Leave += new System.EventHandler(this.txtTimeStartMinute_Leave);
            // 
            // txtTimeStartHour
            // 
            this.txtTimeStartHour.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeStartHour.Location = new System.Drawing.Point(76, 107);
            this.txtTimeStartHour.Name = "txtTimeStartHour";
            this.txtTimeStartHour.Size = new System.Drawing.Size(24, 20);
            this.txtTimeStartHour.TabIndex = 6;
            this.txtTimeStartHour.Text = "HH";
            this.txtTimeStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeStartHour.Enter += new System.EventHandler(this.txtTimeStartHour_Enter);
            this.txtTimeStartHour.Leave += new System.EventHandler(this.txtTimeStartHour_Leave);
            // 
            // formMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 234);
            this.Controls.Add(this.txtTimeStartHour);
            this.Controls.Add(this.txtTimeStartMinute);
            this.Controls.Add(this.txtTimeStartSecond);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkAudio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSubs);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.comboQuality);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtMaxSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webm Converter";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel lblThreads;
        private System.Windows.Forms.ComboBox comboQuality;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.TextBox txtSubs;
        private System.Windows.Forms.OpenFileDialog subsFileDialog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkAudio;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTimeStartSecond;
        private System.Windows.Forms.TextBox txtTimeStartMinute;
        private System.Windows.Forms.TextBox txtTimeStartHour;
    }
}

