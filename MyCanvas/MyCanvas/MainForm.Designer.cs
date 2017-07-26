namespace MyCanvas
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMN = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape_Line = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape_Circle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape_Free = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape_Text = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Shape_Color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Shape_Convert = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTB = new System.Windows.Forms.ToolStrip();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LineBtn = new System.Windows.Forms.ToolStripButton();
            this.CirceltBtn = new System.Windows.Forms.ToolStripButton();
            this.FreeBtn = new System.Windows.Forms.ToolStripButton();
            this.TextBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ConvertClrBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorBtn = new System.Windows.Forms.ToolStripButton();
            this.polygon_b = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.l_width = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.OpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.SaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.ColorDlg = new System.Windows.Forms.ColorDialog();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.ChainView = new System.Windows.Forms.TextBox();
            this.MainMN.SuspendLayout();
            this.MainTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMN
            // 
            this.MainMN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Shape,
            this.menu_Help});
            this.MainMN.Location = new System.Drawing.Point(0, 0);
            this.MainMN.Name = "MainMN";
            this.MainMN.Size = new System.Drawing.Size(972, 24);
            this.MainMN.TabIndex = 0;
            this.MainMN.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File_New,
            this.menu_File_Open,
            this.menu_File_Save,
            this.toolStripSeparator1,
            this.menu_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "&File";
            // 
            // menu_File_New
            // 
            this.menu_File_New.Name = "menu_File_New";
            this.menu_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_File_New.Size = new System.Drawing.Size(146, 22);
            this.menu_File_New.Text = "&New";
            this.menu_File_New.Click += new System.EventHandler(this.menu_File_New_Click);
            // 
            // menu_File_Open
            // 
            this.menu_File_Open.Name = "menu_File_Open";
            this.menu_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_File_Open.Size = new System.Drawing.Size(146, 22);
            this.menu_File_Open.Text = "&Open";
            this.menu_File_Open.Click += new System.EventHandler(this.menu_File_Open_Click);
            // 
            // menu_File_Save
            // 
            this.menu_File_Save.Name = "menu_File_Save";
            this.menu_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_File_Save.Size = new System.Drawing.Size(146, 22);
            this.menu_File_Save.Text = "&Save";
            this.menu_File_Save.Click += new System.EventHandler(this.menu_File_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menu_Exit.Size = new System.Drawing.Size(146, 22);
            this.menu_Exit.Text = "&Exit";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // menu_Shape
            // 
            this.menu_Shape.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Shape_Line,
            this.menu_Shape_Circle,
            this.menu_Shape_Free,
            this.menu_Shape_Text,
            this.toolStripSeparator2,
            this.menu_Shape_Color,
            this.menu_Shape_Convert,
            this.polygonToolStripMenuItem});
            this.menu_Shape.Name = "menu_Shape";
            this.menu_Shape.Size = new System.Drawing.Size(52, 20);
            this.menu_Shape.Text = "&Shape";
            // 
            // menu_Shape_Line
            // 
            this.menu_Shape_Line.Name = "menu_Shape_Line";
            this.menu_Shape_Line.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menu_Shape_Line.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Line.Text = "&Line";
            this.menu_Shape_Line.Click += new System.EventHandler(this.menu_Shape_Line_Click);
            // 
            // menu_Shape_Circle
            // 
            this.menu_Shape_Circle.Name = "menu_Shape_Circle";
            this.menu_Shape_Circle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menu_Shape_Circle.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Circle.Text = "&Circle";
            this.menu_Shape_Circle.Click += new System.EventHandler(this.menu_Shape_Circle_Click);
            // 
            // menu_Shape_Free
            // 
            this.menu_Shape_Free.Name = "menu_Shape_Free";
            this.menu_Shape_Free.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menu_Shape_Free.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Free.Text = "Free &Draw";
            this.menu_Shape_Free.Click += new System.EventHandler(this.menu_Shape_Free_Click);
            // 
            // menu_Shape_Text
            // 
            this.menu_Shape_Text.Name = "menu_Shape_Text";
            this.menu_Shape_Text.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menu_Shape_Text.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Text.Text = "&TextOut";
            this.menu_Shape_Text.Click += new System.EventHandler(this.menu_Shape_Text_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // menu_Shape_Color
            // 
            this.menu_Shape_Color.Name = "menu_Shape_Color";
            this.menu_Shape_Color.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menu_Shape_Color.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Color.Text = "Colo&r";
            this.menu_Shape_Color.Click += new System.EventHandler(this.menu_Shape_Color_Click);
            // 
            // menu_Shape_Convert
            // 
            this.menu_Shape_Convert.Name = "menu_Shape_Convert";
            this.menu_Shape_Convert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menu_Shape_Convert.Size = new System.Drawing.Size(187, 22);
            this.menu_Shape_Convert.Text = "Con&vertColor";
            this.menu_Shape_Convert.Click += new System.EventHandler(this.menu_Shape_Convert_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_About});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(44, 20);
            this.menu_Help.Text = "&Help";
            // 
            // menu_help_About
            // 
            this.menu_help_About.Name = "menu_help_About";
            this.menu_help_About.Size = new System.Drawing.Size(107, 22);
            this.menu_help_About.Text = "&About";
            this.menu_help_About.Click += new System.EventHandler(this.menu_help_About_Click);
            // 
            // MainTB
            // 
            this.MainTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBtn,
            this.OpenBtn,
            this.SaveBtn,
            this.toolStripSeparator3,
            this.LineBtn,
            this.CirceltBtn,
            this.FreeBtn,
            this.TextBtn,
            this.toolStripSeparator4,
            this.ConvertClrBtn,
            this.toolStripSeparator5,
            this.ColorBtn,
            this.polygon_b,
            this.toolStripButton1,
            this.Clear,
            this.l_width,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.MainTB.Location = new System.Drawing.Point(0, 24);
            this.MainTB.Name = "MainTB";
            this.MainTB.Size = new System.Drawing.Size(972, 25);
            this.MainTB.TabIndex = 1;
            this.MainTB.Text = "toolStrip1";
            // 
            // NewBtn
            // 
            this.NewBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewBtn.Image = global::MyCanvas.Properties.Resources.New;
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(23, 22);
            this.NewBtn.Text = "toolStripButton1";
            this.NewBtn.ToolTipText = "새 파일";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenBtn.Image = global::MyCanvas.Properties.Resources.Open;
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(23, 22);
            this.OpenBtn.Text = "toolStripButton2";
            this.OpenBtn.ToolTipText = "파일 열기";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveBtn.Image = global::MyCanvas.Properties.Resources.Save;
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(23, 22);
            this.SaveBtn.Text = "toolStripButton3";
            this.SaveBtn.ToolTipText = "파일 저장";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LineBtn
            // 
            this.LineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineBtn.Image = global::MyCanvas.Properties.Resources.Line;
            this.LineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(23, 22);
            this.LineBtn.Text = "toolStripButton4";
            this.LineBtn.ToolTipText = "직선";
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // CirceltBtn
            // 
            this.CirceltBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CirceltBtn.Image = global::MyCanvas.Properties.Resources.Circle;
            this.CirceltBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CirceltBtn.Name = "CirceltBtn";
            this.CirceltBtn.Size = new System.Drawing.Size(23, 22);
            this.CirceltBtn.Text = "toolStripButton6";
            this.CirceltBtn.ToolTipText = "원";
            this.CirceltBtn.Click += new System.EventHandler(this.CirceltBtn_Click);
            // 
            // FreeBtn
            // 
            this.FreeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FreeBtn.Image = global::MyCanvas.Properties.Resources.Free;
            this.FreeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FreeBtn.Name = "FreeBtn";
            this.FreeBtn.Size = new System.Drawing.Size(23, 22);
            this.FreeBtn.Text = "toolStripButton7";
            this.FreeBtn.ToolTipText = "Free Draw";
            this.FreeBtn.Click += new System.EventHandler(this.FreeBtn_Click);
            // 
            // TextBtn
            // 
            this.TextBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TextBtn.Image = global::MyCanvas.Properties.Resources.TextOut;
            this.TextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TextBtn.Name = "TextBtn";
            this.TextBtn.Size = new System.Drawing.Size(23, 22);
            this.TextBtn.Text = "toolStripButton8";
            this.TextBtn.ToolTipText = "문자 출력";
            this.TextBtn.Click += new System.EventHandler(this.TextBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ConvertClrBtn
            // 
            this.ConvertClrBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ConvertClrBtn.Image = global::MyCanvas.Properties.Resources.ConvertClr;
            this.ConvertClrBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConvertClrBtn.Name = "ConvertClrBtn";
            this.ConvertClrBtn.Size = new System.Drawing.Size(23, 22);
            this.ConvertClrBtn.Text = "toolStripButton9";
            this.ConvertClrBtn.ToolTipText = "색을 변환합니다.";
            this.ConvertClrBtn.Click += new System.EventHandler(this.ConvertClrBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ColorBtn
            // 
            this.ColorBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorBtn.Image = ((System.Drawing.Image)(resources.GetObject("ColorBtn.Image")));
            this.ColorBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(40, 22);
            this.ColorBtn.Text = "Color";
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // polygon_b
            // 
            this.polygon_b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.polygon_b.Image = global::MyCanvas.Properties.Resources.RectAngle;
            this.polygon_b.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.polygon_b.Name = "polygon_b";
            this.polygon_b.Size = new System.Drawing.Size(23, 22);
            this.polygon_b.Text = "polygon";
            this.polygon_b.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::MyCanvas.Properties.Resources.지우개;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "지우개";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // Clear
            // 
            this.Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear.Image = global::MyCanvas.Properties.Resources.Clear;
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(23, 22);
            this.Clear.Text = "clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // l_width
            // 
            this.l_width.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.l_width.Image = global::MyCanvas.Properties.Resources.굵기;
            this.l_width.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.l_width.Name = "l_width";
            this.l_width.Size = new System.Drawing.Size(23, 22);
            this.l_width.Text = "l_width";
            this.l_width.Click += new System.EventHandler(this.l_width_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::MyCanvas.Properties.Resources.언두;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.Undo_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::MyCanvas.Properties.Resources.리두;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.Redo_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::MyCanvas.Properties.Resources.잘라내기;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "캡처";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // OpenDlg
            // 
            this.OpenDlg.FileName = "openFileDialog1";
            this.OpenDlg.Filter = "비트맵 파일(*.bmp)|*.bmp|모든파일(*.*)|*.*";
            // 
            // SaveDlg
            // 
            this.SaveDlg.Filter = "비트맵 파일(*.bmp)|*.bmp|모든파일(*.*)|*.*";
            // 
            // Canvas
            // 
            this.Canvas.Location = new System.Drawing.Point(3, 53);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(773, 489);
            this.Canvas.TabIndex = 2;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // ChainView
            // 
            this.ChainView.Location = new System.Drawing.Point(782, 68);
            this.ChainView.Multiline = true;
            this.ChainView.Name = "ChainView";
            this.ChainView.Size = new System.Drawing.Size(178, 289);
            this.ChainView.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 545);
            this.Controls.Add(this.ChainView);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.MainTB);
            this.Controls.Add(this.MainMN);
            this.MainMenuStrip = this.MainMN;
            this.Name = "MainForm";
            this.Text = "MyCanvas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMN.ResumeLayout(false);
            this.MainMN.PerformLayout();
            this.MainTB.ResumeLayout(false);
            this.MainTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMN;
        private System.Windows.Forms.ToolStrip MainTB;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.OpenFileDialog OpenDlg;
        private System.Windows.Forms.SaveFileDialog SaveDlg;
        private System.Windows.Forms.ColorDialog ColorDlg;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_File_New;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem menu_File_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Line;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Circle;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Free;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Text;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Color;
        private System.Windows.Forms.ToolStripMenuItem menu_Shape_Convert;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_help_About;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton LineBtn;
        private System.Windows.Forms.ToolStripButton CirceltBtn;
        private System.Windows.Forms.ToolStripButton FreeBtn;
        private System.Windows.Forms.ToolStripButton TextBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ConvertClrBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ColorBtn;
        private System.Windows.Forms.ToolStripButton polygon_b;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Clear;
        private System.Windows.Forms.ToolStripButton l_width;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.TextBox ChainView;
    }
}

