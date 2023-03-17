namespace CF_P2P
{
    partial class GFN
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
            this.components = new System.ComponentModel.Container();
            this.DownloadLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DownloadProgressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.WaitFile = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LaunchEXE = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // DownloadLBL
            // 
            this.DownloadLBL.AutoSize = false;
            this.DownloadLBL.BackColor = System.Drawing.Color.Transparent;
            this.DownloadLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadLBL.ForeColor = System.Drawing.Color.White;
            this.DownloadLBL.Location = new System.Drawing.Point(39, 298);
            this.DownloadLBL.Name = "DownloadLBL";
            this.DownloadLBL.Size = new System.Drawing.Size(776, 21);
            this.DownloadLBL.TabIndex = 13;
            this.DownloadLBL.Text = "Waiting for files";
            this.DownloadLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadLBL.Click += new System.EventHandler(this.UploadLBL_Click);
            // 
            // DownloadProgressbar
            // 
            this.DownloadProgressbar.BorderRadius = 6;
            this.DownloadProgressbar.Location = new System.Drawing.Point(39, 325);
            this.DownloadProgressbar.Name = "DownloadProgressbar";
            this.DownloadProgressbar.Size = new System.Drawing.Size(776, 24);
            this.DownloadProgressbar.TabIndex = 12;
            this.DownloadProgressbar.Text = "guna2ProgressBar1";
            this.DownloadProgressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // WaitFile
            // 
            this.WaitFile.Enabled = true;
            this.WaitFile.Interval = 10000;
            this.WaitFile.Tick += new System.EventHandler(this.WaitFile_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(839, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(788, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(206, 22);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Zortos P2P (Waiting For File)";
            // 
            // LaunchEXE
            // 
            this.LaunchEXE.BorderRadius = 6;
            this.LaunchEXE.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LaunchEXE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LaunchEXE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LaunchEXE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LaunchEXE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.LaunchEXE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LaunchEXE.ForeColor = System.Drawing.Color.White;
            this.LaunchEXE.Location = new System.Drawing.Point(260, 160);
            this.LaunchEXE.Name = "LaunchEXE";
            this.LaunchEXE.Size = new System.Drawing.Size(336, 45);
            this.LaunchEXE.TabIndex = 18;
            this.LaunchEXE.Text = "Launch Exe";
            this.LaunchEXE.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // GFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(887, 361);
            this.Controls.Add(this.LaunchEXE);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.DownloadLBL);
            this.Controls.Add(this.DownloadProgressbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GFN";
            this.Text = "GFN";
            this.Load += new System.EventHandler(this.GFN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel DownloadLBL;
        private Guna.UI2.WinForms.Guna2ProgressBar DownloadProgressbar;
        private System.Windows.Forms.Timer WaitFile;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button LaunchEXE;
    }
}