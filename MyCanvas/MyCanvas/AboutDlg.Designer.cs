namespace MyCanvas
{
    partial class AboutDlg
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
            this.ProgramInfo = new System.Windows.Forms.Label();
            this.LicenseInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramInfo
            // 
            this.ProgramInfo.AutoSize = true;
            this.ProgramInfo.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProgramInfo.Location = new System.Drawing.Point(12, 15);
            this.ProgramInfo.Name = "ProgramInfo";
            this.ProgramInfo.Size = new System.Drawing.Size(140, 19);
            this.ProgramInfo.TabIndex = 0;
            this.ProgramInfo.Text = "myCanvas 1.0";
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.Location = new System.Drawing.Point(14, 48);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(138, 24);
            this.LicenseInfo.TabIndex = 1;
            this.LicenseInfo.Text = "윈도우즈 프로그래밍";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AboutDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LicenseInfo);
            this.Controls.Add(this.ProgramInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDlg";
            this.Text = "myCanvas 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramInfo;
        private System.Windows.Forms.Label LicenseInfo;
        private System.Windows.Forms.Button button1;
    }
}