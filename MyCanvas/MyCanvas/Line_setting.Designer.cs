namespace MyCanvas
{
    partial class Line_setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linesizetext = new System.Windows.Forms.TextBox();
            this.Line_style = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "선 굵기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "선 스타일";
            // 
            // linesizetext
            // 
            this.linesizetext.Location = new System.Drawing.Point(26, 78);
            this.linesizetext.Name = "linesizetext";
            this.linesizetext.Size = new System.Drawing.Size(100, 21);
            this.linesizetext.TabIndex = 2;
            // 
            // Line_style
            // 
            this.Line_style.FormattingEnabled = true;
            this.Line_style.Items.AddRange(new object[] {
            "Dash",
            "DashDot",
            "DashDotDot",
            "Dot",
            "Solid"});
            this.Line_style.Location = new System.Drawing.Point(201, 78);
            this.Line_style.Name = "Line_style";
            this.Line_style.Size = new System.Drawing.Size(121, 20);
            this.Line_style.TabIndex = 3;
     //       this.Line_style.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Line_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Line_style);
            this.Controls.Add(this.linesizetext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Line_setting";
            this.Text = "Line_setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox linesizetext;
        private System.Windows.Forms.ComboBox Line_style;
        private System.Windows.Forms.Button button1;
    }
}