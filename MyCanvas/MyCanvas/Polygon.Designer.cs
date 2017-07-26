namespace MyCanvas
{
    partial class Polygon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Polygon));
            this.tri_b = new System.Windows.Forms.Button();
            this.rect_b = new System.Windows.Forms.Button();
            this.Pent_b = new System.Windows.Forms.Button();
            this.Hexa_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tri_b
            // 
            this.tri_b.BackColor = System.Drawing.Color.White;
            this.tri_b.Image = ((System.Drawing.Image)(resources.GetObject("tri_b.Image")));
            this.tri_b.Location = new System.Drawing.Point(46, 36);
            this.tri_b.Name = "tri_b";
            this.tri_b.Size = new System.Drawing.Size(102, 80);
            this.tri_b.TabIndex = 0;
            this.tri_b.UseVisualStyleBackColor = false;
            this.tri_b.Click += new System.EventHandler(this.tri_b_Click);
            // 
            // rect_b
            // 
            this.rect_b.BackColor = System.Drawing.Color.White;
            this.rect_b.Image = ((System.Drawing.Image)(resources.GetObject("rect_b.Image")));
            this.rect_b.Location = new System.Drawing.Point(170, 36);
            this.rect_b.Name = "rect_b";
            this.rect_b.Size = new System.Drawing.Size(102, 80);
            this.rect_b.TabIndex = 0;
            this.rect_b.UseVisualStyleBackColor = false;
            this.rect_b.Click += new System.EventHandler(this.rect_b_Click);
            // 
            // Pent_b
            // 
            this.Pent_b.BackColor = System.Drawing.Color.White;
            this.Pent_b.Image = ((System.Drawing.Image)(resources.GetObject("Pent_b.Image")));
            this.Pent_b.Location = new System.Drawing.Point(46, 171);
            this.Pent_b.Name = "Pent_b";
            this.Pent_b.Size = new System.Drawing.Size(102, 80);
            this.Pent_b.TabIndex = 0;
            this.Pent_b.UseVisualStyleBackColor = false;
            this.Pent_b.Click += new System.EventHandler(this.pent_b_Click);
            // 
            // Hexa_b
            // 
            this.Hexa_b.BackColor = System.Drawing.Color.White;
            this.Hexa_b.Image = ((System.Drawing.Image)(resources.GetObject("Hexa_b.Image")));
            this.Hexa_b.Location = new System.Drawing.Point(170, 171);
            this.Hexa_b.Name = "Hexa_b";
            this.Hexa_b.Size = new System.Drawing.Size(102, 80);
            this.Hexa_b.TabIndex = 0;
            this.Hexa_b.UseVisualStyleBackColor = false;
            this.Hexa_b.Click += new System.EventHandler(this.Hexa_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "삼각형";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "사각형";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "오각형";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "육각형";
            // 
            // Polygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hexa_b);
            this.Controls.Add(this.Pent_b);
            this.Controls.Add(this.rect_b);
            this.Controls.Add(this.tri_b);
            this.Name = "Polygon";
            this.Text = "Polygon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tri_b;
        private System.Windows.Forms.Button rect_b;
        private System.Windows.Forms.Button Pent_b;
        private System.Windows.Forms.Button Hexa_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}