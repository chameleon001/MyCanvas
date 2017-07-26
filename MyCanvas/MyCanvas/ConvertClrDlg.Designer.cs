namespace MyCanvas
{
    partial class ConvertClrDlg
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
            this.SrcClrBox = new System.Windows.Forms.PictureBox();
            this.TrgClrBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ColorDlg = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SrcClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrgClrBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SrcClrBox
            // 
            this.SrcClrBox.BackColor = System.Drawing.Color.White;
            this.SrcClrBox.Location = new System.Drawing.Point(17, 55);
            this.SrcClrBox.Name = "SrcClrBox";
            this.SrcClrBox.Size = new System.Drawing.Size(146, 200);
            this.SrcClrBox.TabIndex = 0;
            this.SrcClrBox.TabStop = false;
            // 
            // TrgClrBox
            // 
            this.TrgClrBox.BackColor = System.Drawing.Color.White;
            this.TrgClrBox.Location = new System.Drawing.Point(236, 55);
            this.TrgClrBox.Name = "TrgClrBox";
            this.TrgClrBox.Size = new System.Drawing.Size(146, 200);
            this.TrgClrBox.TabIndex = 1;
            this.TrgClrBox.TabStop = false;
            this.TrgClrBox.Click += new System.EventHandler(this.TrgClrBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "원본 색상";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "바꿀 색상";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "-->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TrgClrBox);
            this.groupBox1.Controls.Add(this.SrcClrBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 285);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "색상변환";
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(139, 344);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(150, 25);
            this.OKBtn.TabIndex = 6;
            this.OKBtn.Text = "확인";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ConvertClrDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 395);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConvertClrDlg";
            this.Text = "Convert Color";
            this.Load += new System.EventHandler(this.ConvertClrDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SrcClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrgClrBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SrcClrBox;
        private System.Windows.Forms.PictureBox TrgClrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.ColorDialog ColorDlg;
    }
}