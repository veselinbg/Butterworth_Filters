
namespace Butterworth_Filters
{
    partial class FrmMain
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
            this.TbFilename = new System.Windows.Forms.TextBox();
            this.LblInputFile = new System.Windows.Forms.Label();
            this.BtnFilename = new System.Windows.Forms.Button();
            this.LbOutput = new System.Windows.Forms.ListBox();
            this.BtnProcess = new System.Windows.Forms.Button();
            this.RbHighPass = new System.Windows.Forms.RadioButton();
            this.RbLowPass = new System.Windows.Forms.RadioButton();
            this.RbBandPass = new System.Windows.Forms.RadioButton();
            this.TbOpt1 = new System.Windows.Forms.TextBox();
            this.LblOpt1 = new System.Windows.Forms.Label();
            this.LblHzOpt1 = new System.Windows.Forms.Label();
            this.LblHzOpt2 = new System.Windows.Forms.Label();
            this.TbOpt2 = new System.Windows.Forms.TextBox();
            this.LblOpt2 = new System.Windows.Forms.Label();
            this.LblOpt3 = new System.Windows.Forms.Label();
            this.TbOpt3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbInputHz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbOutputHz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbColumnNum = new System.Windows.Forms.TextBox();
            this.CbHeader = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TbFilename
            // 
            this.TbFilename.AllowDrop = true;
            this.TbFilename.Location = new System.Drawing.Point(67, 15);
            this.TbFilename.Name = "TbFilename";
            this.TbFilename.ReadOnly = true;
            this.TbFilename.Size = new System.Drawing.Size(462, 20);
            this.TbFilename.TabIndex = 0;
            this.TbFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.TbFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // LblInputFile
            // 
            this.LblInputFile.AllowDrop = true;
            this.LblInputFile.AutoSize = true;
            this.LblInputFile.Location = new System.Drawing.Point(12, 18);
            this.LblInputFile.Name = "LblInputFile";
            this.LblInputFile.Size = new System.Drawing.Size(49, 13);
            this.LblInputFile.TabIndex = 1;
            this.LblInputFile.Text = "Filename";
            this.LblInputFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.LblInputFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // BtnFilename
            // 
            this.BtnFilename.AllowDrop = true;
            this.BtnFilename.Location = new System.Drawing.Point(535, 15);
            this.BtnFilename.Name = "BtnFilename";
            this.BtnFilename.Size = new System.Drawing.Size(24, 20);
            this.BtnFilename.TabIndex = 2;
            this.BtnFilename.Text = "...";
            this.BtnFilename.UseVisualStyleBackColor = true;
            this.BtnFilename.Click += new System.EventHandler(this.BtnFilename_Click);
            this.BtnFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.BtnFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // LbOutput
            // 
            this.LbOutput.AllowDrop = true;
            this.LbOutput.FormattingEnabled = true;
            this.LbOutput.Location = new System.Drawing.Point(12, 65);
            this.LbOutput.Name = "LbOutput";
            this.LbOutput.Size = new System.Drawing.Size(544, 147);
            this.LbOutput.TabIndex = 3;
            this.LbOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.LbOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(477, 220);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(79, 28);
            this.BtnProcess.TabIndex = 4;
            this.BtnProcess.Text = "&Process";
            this.BtnProcess.UseVisualStyleBackColor = true;
            this.BtnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // RbHighPass
            // 
            this.RbHighPass.AutoSize = true;
            this.RbHighPass.Checked = true;
            this.RbHighPass.Location = new System.Drawing.Point(12, 251);
            this.RbHighPass.Name = "RbHighPass";
            this.RbHighPass.Size = new System.Drawing.Size(70, 17);
            this.RbHighPass.TabIndex = 5;
            this.RbHighPass.TabStop = true;
            this.RbHighPass.Text = "HighPass";
            this.RbHighPass.UseVisualStyleBackColor = true;
            this.RbHighPass.CheckedChanged += new System.EventHandler(this.RbHighPass_CheckedChanged);
            // 
            // RbLowPass
            // 
            this.RbLowPass.AutoSize = true;
            this.RbLowPass.Location = new System.Drawing.Point(12, 274);
            this.RbLowPass.Name = "RbLowPass";
            this.RbLowPass.Size = new System.Drawing.Size(68, 17);
            this.RbLowPass.TabIndex = 6;
            this.RbLowPass.Text = "LowPass";
            this.RbLowPass.UseVisualStyleBackColor = true;
            this.RbLowPass.CheckedChanged += new System.EventHandler(this.RbLowPass_CheckedChanged);
            // 
            // RbBandPass
            // 
            this.RbBandPass.AutoSize = true;
            this.RbBandPass.Location = new System.Drawing.Point(12, 297);
            this.RbBandPass.Name = "RbBandPass";
            this.RbBandPass.Size = new System.Drawing.Size(73, 17);
            this.RbBandPass.TabIndex = 7;
            this.RbBandPass.Text = "BandPass";
            this.RbBandPass.UseVisualStyleBackColor = true;
            this.RbBandPass.CheckedChanged += new System.EventHandler(this.RbBandPass_CheckedChanged);
            // 
            // TbOpt1
            // 
            this.TbOpt1.Location = new System.Drawing.Point(298, 251);
            this.TbOpt1.Name = "TbOpt1";
            this.TbOpt1.Size = new System.Drawing.Size(34, 20);
            this.TbOpt1.TabIndex = 8;
            this.TbOpt1.Text = "1.6";
            // 
            // LblOpt1
            // 
            this.LblOpt1.Location = new System.Drawing.Point(104, 254);
            this.LblOpt1.Name = "LblOpt1";
            this.LblOpt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblOpt1.Size = new System.Drawing.Size(188, 16);
            this.LblOpt1.TabIndex = 9;
            this.LblOpt1.Text = "Cutoff Frequency";
            // 
            // LblHzOpt1
            // 
            this.LblHzOpt1.AutoSize = true;
            this.LblHzOpt1.Location = new System.Drawing.Point(333, 255);
            this.LblHzOpt1.Name = "LblHzOpt1";
            this.LblHzOpt1.Size = new System.Drawing.Size(20, 13);
            this.LblHzOpt1.TabIndex = 10;
            this.LblHzOpt1.Text = "Hz";
            // 
            // LblHzOpt2
            // 
            this.LblHzOpt2.AutoSize = true;
            this.LblHzOpt2.Location = new System.Drawing.Point(333, 278);
            this.LblHzOpt2.Name = "LblHzOpt2";
            this.LblHzOpt2.Size = new System.Drawing.Size(20, 13);
            this.LblHzOpt2.TabIndex = 12;
            this.LblHzOpt2.Text = "Hz";
            this.LblHzOpt2.Visible = false;
            // 
            // TbOpt2
            // 
            this.TbOpt2.Location = new System.Drawing.Point(298, 274);
            this.TbOpt2.Name = "TbOpt2";
            this.TbOpt2.Size = new System.Drawing.Size(34, 20);
            this.TbOpt2.TabIndex = 11;
            this.TbOpt2.Text = "20";
            // 
            // LblOpt2
            // 
            this.LblOpt2.Location = new System.Drawing.Point(104, 275);
            this.LblOpt2.Name = "LblOpt2";
            this.LblOpt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblOpt2.Size = new System.Drawing.Size(188, 16);
            this.LblOpt2.TabIndex = 13;
            this.LblOpt2.Text = "Sections";
            // 
            // LblOpt3
            // 
            this.LblOpt3.Location = new System.Drawing.Point(104, 298);
            this.LblOpt3.Name = "LblOpt3";
            this.LblOpt3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblOpt3.Size = new System.Drawing.Size(188, 16);
            this.LblOpt3.TabIndex = 16;
            this.LblOpt3.Text = "Sections";
            this.LblOpt3.Visible = false;
            // 
            // TbOpt3
            // 
            this.TbOpt3.Location = new System.Drawing.Point(298, 297);
            this.TbOpt3.Name = "TbOpt3";
            this.TbOpt3.Size = new System.Drawing.Size(34, 20);
            this.TbOpt3.TabIndex = 14;
            this.TbOpt3.Text = "1.6";
            this.TbOpt3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Input Frequency";
            // 
            // TbInputHz
            // 
            this.TbInputHz.Location = new System.Drawing.Point(94, 217);
            this.TbInputHz.Name = "TbInputHz";
            this.TbInputHz.Size = new System.Drawing.Size(37, 20);
            this.TbInputHz.TabIndex = 17;
            this.TbInputHz.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hz";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Output Frequency";
            this.label4.Visible = false;
            // 
            // TbOutputHz
            // 
            this.TbOutputHz.Location = new System.Drawing.Point(281, 217);
            this.TbOutputHz.Name = "TbOutputHz";
            this.TbOutputHz.Size = new System.Drawing.Size(37, 20);
            this.TbOutputHz.TabIndex = 20;
            this.TbOutputHz.Text = "1000";
            this.TbOutputHz.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "CSV column number";
            // 
            // TbColumnNum
            // 
            this.TbColumnNum.Location = new System.Drawing.Point(170, 38);
            this.TbColumnNum.Name = "TbColumnNum";
            this.TbColumnNum.Size = new System.Drawing.Size(22, 20);
            this.TbColumnNum.TabIndex = 23;
            this.TbColumnNum.Text = "6";
            // 
            // CbHeader
            // 
            this.CbHeader.AutoSize = true;
            this.CbHeader.Checked = true;
            this.CbHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbHeader.Location = new System.Drawing.Point(198, 40);
            this.CbHeader.Name = "CbHeader";
            this.CbHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CbHeader.Size = new System.Drawing.Size(84, 17);
            this.CbHeader.TabIndex = 25;
            this.CbHeader.Text = "Header Line";
            this.CbHeader.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 297);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(182, 16);
            this.progressBar1.TabIndex = 26;
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 327);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CbHeader);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbColumnNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbOutputHz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbInputHz);
            this.Controls.Add(this.LblOpt3);
            this.Controls.Add(this.TbOpt3);
            this.Controls.Add(this.LblOpt2);
            this.Controls.Add(this.LblHzOpt2);
            this.Controls.Add(this.TbOpt2);
            this.Controls.Add(this.LblHzOpt1);
            this.Controls.Add(this.LblOpt1);
            this.Controls.Add(this.TbOpt1);
            this.Controls.Add(this.RbBandPass);
            this.Controls.Add(this.RbLowPass);
            this.Controls.Add(this.RbHighPass);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.LbOutput);
            this.Controls.Add(this.BtnFilename);
            this.Controls.Add(this.LblInputFile);
            this.Controls.Add(this.TbFilename);
            this.Name = "FrmMain";
            this.Text = "Butterworth Filters";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.All_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.All_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbFilename;
        private System.Windows.Forms.Label LblInputFile;
        private System.Windows.Forms.Button BtnFilename;
        private System.Windows.Forms.ListBox LbOutput;
        private System.Windows.Forms.Button BtnProcess;
        private System.Windows.Forms.RadioButton RbHighPass;
        private System.Windows.Forms.RadioButton RbLowPass;
        private System.Windows.Forms.RadioButton RbBandPass;
        private System.Windows.Forms.TextBox TbOpt1;
        private System.Windows.Forms.Label LblOpt1;
        private System.Windows.Forms.Label LblHzOpt1;
        private System.Windows.Forms.Label LblHzOpt2;
        private System.Windows.Forms.TextBox TbOpt2;
        private System.Windows.Forms.Label LblOpt2;
        private System.Windows.Forms.Label LblOpt3;
        private System.Windows.Forms.TextBox TbOpt3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInputHz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbOutputHz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbColumnNum;
        private System.Windows.Forms.CheckBox CbHeader;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

