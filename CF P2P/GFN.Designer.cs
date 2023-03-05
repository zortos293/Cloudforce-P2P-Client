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
            this.SuspendLayout();
            // 
            // DownloadLBL
            // 
            this.DownloadLBL.AutoSize = false;
            this.DownloadLBL.BackColor = System.Drawing.Color.Transparent;
            this.DownloadLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadLBL.ForeColor = System.Drawing.Color.White;
            this.DownloadLBL.Location = new System.Drawing.Point(12, 12);
            this.DownloadLBL.Name = "DownloadLBL";
            this.DownloadLBL.Size = new System.Drawing.Size(776, 21);
            this.DownloadLBL.TabIndex = 13;
            this.DownloadLBL.Text = "Waiting for files";
            this.DownloadLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadLBL.Click += new System.EventHandler(this.UploadLBL_Click);
            // 
            // DownloadProgressbar
            // 
            this.DownloadProgressbar.Location = new System.Drawing.Point(12, 39);
            this.DownloadProgressbar.Name = "DownloadProgressbar";
            this.DownloadProgressbar.Size = new System.Drawing.Size(776, 24);
            this.DownloadProgressbar.TabIndex = 12;
            this.DownloadProgressbar.Text = "guna2ProgressBar1";
            this.DownloadProgressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // WaitFile
            // 
            this.WaitFile.Interval = 1000;
            this.WaitFile.Tick += new System.EventHandler(this.WaitFile_Tick);
            // 
            // GFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 78);
            this.Controls.Add(this.DownloadLBL);
            this.Controls.Add(this.DownloadProgressbar);
            this.Name = "GFN";
            this.Text = "GFN";
            this.Load += new System.EventHandler(this.GFN_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel DownloadLBL;
        private Guna.UI2.WinForms.Guna2ProgressBar DownloadProgressbar;
        private System.Windows.Forms.Timer WaitFile;
    }
}