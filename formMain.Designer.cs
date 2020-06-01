﻿namespace MasterOfWebM
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
            this.txtTimeStart = new System.Windows.Forms.TextBox();
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
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(11, 36);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(51, 23);
            this.btnOutput.TabIndex = 2;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(11, 10);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(51, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(75, 38);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(332, 20);
            this.txtOutput.TabIndex = 2;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(75, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(332, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(77, 144);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(69, 20);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(77, 118);
            this.txtLength.MaxLength = 3;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(69, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeStart.Location = new System.Drawing.Point(77, 91);
            this.txtTimeStart.MaxLength = 8;
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(69, 20);
            this.txtTimeStart.TabIndex = 3;
            this.txtTimeStart.Text = "HH:MM:SS";
            this.txtTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimeStart.Enter += new System.EventHandler(this.txtTimeStart_Enter);
            this.txtTimeStart.Leave += new System.EventHandler(this.txtTimeStart_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Start:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(322, 91);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 9;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(161, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Size:";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaxSize.Location = new System.Drawing.Point(223, 91);
            this.txtMaxSize.MaxLength = 4;
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(69, 20);
            this.txtMaxSize.TabIndex = 6;
            this.txtMaxSize.Text = "3.8";
            this.txtMaxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
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
            this.comboQuality.Location = new System.Drawing.Point(223, 118);
            this.comboQuality.Name = "comboQuality";
            this.comboQuality.Size = new System.Drawing.Size(69, 21);
            this.comboQuality.TabIndex = 8;
            this.comboQuality.SelectedIndexChanged += new System.EventHandler(this.comboQuality_SelectedIndexChanged);
            // 
            // btnSubs
            // 
            this.btnSubs.Location = new System.Drawing.Point(11, 62);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(51, 23);
            this.btnSubs.TabIndex = 10;
            this.btnSubs.Text = "Subs";
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // txtSubs
            // 
            this.txtSubs.Location = new System.Drawing.Point(75, 64);
            this.txtSubs.Name = "txtSubs";
            this.txtSubs.Size = new System.Drawing.Size(332, 20);
            this.txtSubs.TabIndex = 11;
            // 
            // subsFileDialog
            // 
            this.subsFileDialog.Filter = "SubStation Alpha Subtitles (*.ass)|*.ass|SubRip Text (*.srt)|*.srt";
            this.subsFileDialog.RestoreDirectory = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(322, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Audio:";
            // 
            // checkAudio
            // 
            this.checkAudio.AutoSize = true;
            this.checkAudio.Location = new System.Drawing.Point(250, 147);
            this.checkAudio.Name = "checkAudio";
            this.checkAudio.Size = new System.Drawing.Size(15, 14);
            this.checkAudio.TabIndex = 14;
            this.checkAudio.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(322, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 205);
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
            this.Controls.Add(this.txtTimeStart);
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
            this.Text = "!WebM.y.TsM Converter";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.formMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.formMain_DragEnter);
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
        private System.Windows.Forms.TextBox txtTimeStart;
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
    }
}

