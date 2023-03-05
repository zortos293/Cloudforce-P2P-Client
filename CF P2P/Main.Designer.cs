namespace CF_P2P
{
    partial class Main
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.UploadProgressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.UploadLBL = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(279, 33);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(219, 21);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Drag and Drop your file here";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(776, 90);
            this.guna2Panel1.TabIndex = 8;
            // 
            // UploadProgressbar
            // 
            this.UploadProgressbar.Location = new System.Drawing.Point(12, 174);
            this.UploadProgressbar.Name = "UploadProgressbar";
            this.UploadProgressbar.Size = new System.Drawing.Size(776, 24);
            this.UploadProgressbar.TabIndex = 9;
            this.UploadProgressbar.Text = "guna2ProgressBar1";
            this.UploadProgressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // UploadLBL
            // 
            this.UploadLBL.AutoSize = false;
            this.UploadLBL.BackColor = System.Drawing.Color.Transparent;
            this.UploadLBL.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadLBL.ForeColor = System.Drawing.Color.White;
            this.UploadLBL.Location = new System.Drawing.Point(12, 147);
            this.UploadLBL.Name = "UploadLBL";
            this.UploadLBL.Size = new System.Drawing.Size(776, 21);
            this.UploadLBL.TabIndex = 10;
            this.UploadLBL.Text = "Uploading";
            this.UploadLBL.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 210);
            this.Controls.Add(this.UploadLBL);
            this.Controls.Add(this.UploadProgressbar);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar UploadProgressbar;
        private Guna.UI2.WinForms.Guna2HtmlLabel UploadLBL;
    }
}