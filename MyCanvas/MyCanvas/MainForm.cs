using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCanvas
{

   
    public partial class MainForm : Form
    {

        LinkedList<Chain> list1 = new LinkedList<Chain>();//u
        LinkedList<Chain> list2 = new LinkedList<Chain>();//d
       
        LinkedList<Chain> list4 = new LinkedList<Chain>(); //부드러운 선용


      //  LinkedList<Chain> list_mc = new LinkedList<Chain>(); // 아직 안씀
        LinkedList<Chain> list_m = new LinkedList<Chain>(); // 아직 안씀

        LinkedList<Point_free> list_free = new LinkedList<Point_free>();
        

        public MainForm()
        {
            InitializeComponent();

            if(menual == 1)
            {
                MessageBox.Show(this, "freedraw를 되돌리기 위해선 여러번을 눌러야 조금 씩 사라집니다..");
            }
        }

        private Point Point1; // 시작점
        private Point Point2; // 종료점
        private Point Point4; //움기기용
        private Point Point5; // 움기기용
        private Point Point3; // 객체 무브용

        private Color myColor; // myColor에 색 정보 저장

        public int menual = 1;
      

        public static int angle_size = 0;
        public static int AngleSize
        {
            get
            {
                return angle_size;
            }
            set
            {
                angle_size = value;
            }
        }

        public static int line_size = 3;
        public static int LineSize
        {
            get
            {
                return line_size;

            }
            set
            {
                line_size = value;
            }
        }

        public static int line_style;

        public static int LineStyle
        {
            get
            {
                return line_style;
            }
            set
            {
                line_style = value;
            }
        }

        private static Font myfont;
        private static string contents;
        public static Font myFont
        {
            get
            {
                return myfont;
            }
            set
            {
                myfont = value;
            }
        }

        public static string Contents
        {
            get
            {
                return contents;
            }
            set
            {
                contents = value;
            }
        }

        private static Color sourcecolor;
        private static Color targetcolor;

        public static Color SourceColor
        {
            get
            {
                return sourcecolor;
            }
            set
            {
                sourcecolor = value;
            }
        }
        public static Color TargetColor
        {
            get
            {
                return targetcolor;
            }
            set
            {
                targetcolor = value;
            }
        }



        private void Polygon(int angle_size)
        {
            switch (angle_size)
            {
                case 3:
                    SetShape((int)Shape.Triangle);
                    break;
                case 4:
                    SetShape((int)Shape.Rect);
                    break;
                case 5:
                    SetShape((int)Shape.Pentagon);
                    break;
                case 6:
                    SetShape((int)Shape.Hexagon);
                    break;

            }
        }






        public void SetColor()
        {
            if (ColorDlg.ShowDialog() == DialogResult.OK)
                myColor = ColorDlg.Color;

            ColorBtn.BackColor = myColor;
        }

        private int DrawMode;

        public void SetShape(int i) { DrawMode = i; }

        enum Shape : int
        {
            Line,
            Rect,
            Circle,
            FreeLine,
            Text,
            ConvertColor,
            Triangle,
            Pentagon,
            Hexagon,
            Eraser
        }

        private void DrawLine(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
            g.DrawLine(myPen, Point1, Point2);
        }

        private void DrawRectangle(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
            int x, y, width, height;

            if (Point1.X <= Point2.X)
            {
                x = Point1.X;
                width = Point2.X - x;
            }
            else
            {
                x = Point2.X;
                width = Point1.X - x;
            }

            if (Point1.Y <= Point2.Y)
            {
                y = Point1.Y;
                height = Point2.Y - y;
            }
            else
            {
                y = Point2.Y;
                height = Point1.Y - y;
            }
            g.DrawRectangle(myPen, x, y, width, height);
        }

        private void DrawTriangle(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
           

            Point[] points_tri = { new Point((Math.Abs(Point1.X-Point2.X))/2+Point1.X, Point1.Y), new Point(Point1.X,Point2.Y), new Point(Point2.X,Point2.Y) };
            g.DrawPolygon(myPen, points_tri);

        }

        private void DrawHexa(Pen myPen, Graphics g, Point Point1, Point Point2)
        {



            Point[] points_hexa = { new Point(Point1.X, Point1.Y + (Point2.Y - Point1.Y )/3), new Point(Point1.X, Point1.Y+2*(Point2.Y - Point1.Y)/3),
                new Point(Point1.X+(Point2.X-Point1.X)/2,Point2.Y), new Point(Point2.X,Point1.Y+2*(Point2.Y-Point1.Y)/3),
                new Point(Point2.X,Point1.Y + (Point2.Y - Point1.Y )/3), new Point(Point1.X+(Point2.X-Point1.X)/2, Point1.Y) };
            g.DrawPolygon(myPen, points_hexa);
        }

        private void DrawPenta(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
            int x, y;


            if (Point1.X <= Point2.X)
            {
                x = Point1.X;
  
            }
            else
            {
                x = Point2.X;
                Point2.X = Point1.X;
                Point1.X = x;
        
            }

            if (Point1.Y <= Point2.Y)
            {
                y = Point1.Y;
    
            }
            else
            {
                y = Point2.Y;
                Point2.Y = Point1.Y;
                Point1.Y = y;

            }
          

            Point[] points_penta = { new Point(Math.Abs((Point2.X - Point1.X)) / 2 + Point1.X, Point1.Y), new Point(Point1.X, (Math.Abs((Point1.Y - Point2.Y)) / 3)  + Point1.Y), new Point(Math.Abs(Point2.X - Point1.X)/3+Point1.X, Point2.Y ),
                new Point((Math.Abs(Point2.X - Point1.X) / 3)*2 + Point1.X, Point2.Y), new Point(Point2.X, (Math.Abs((Point1.Y - Point2.Y)) / 3)  + Point1.Y) };

            g.DrawPolygon(myPen, points_penta);
        }

        private void DrawCircle(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
            int x, y, width, height;

            if (Point1.X <= Point2.X)
            {
                x = Point1.X;
                width = Point2.X - x;
            }
            else
            {
                x = Point2.X;
                width = Point1.X - x;
            }

            if (Point1.Y <= Point2.Y)
            {
                y = Point1.Y;
                height = Point2.Y - y;
            }
            else
            {
                y = Point2.Y;
                height = Point1.Y - y;
            }
            g.DrawEllipse(myPen, x, y, width, height);

        }

        // 자유 곡선 그리기
        private void DrawFreeLine(Pen myPen, Graphics g, Point Point1, Point Point2)
        {
            g.DrawLine(myPen, Point1, Point2);
        }

        // 도형 그리기
        private void DrawShape(Chain chain)
        {
            Pen myPen = new Pen(chain.c_color, chain.c_line_size);

            switch (chain.c_line_style)
            {
                case 1:
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 2:
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 3:
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
                case 4:
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 5:
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;

                default:
                    break;
            }
           
            Graphics g = Graphics.FromImage(Canvas.Image);
            switch (chain.c_DrawMode)
            {
                case (int)Shape.Line:
                    DrawLine(myPen, g, chain.c_pt,chain.c_pt2);
                    break;

                case (int)Shape.Rect:
                    DrawRectangle(myPen, g, chain.c_pt, chain.c_pt2);
                    break;

                case (int)Shape.Circle:
                    DrawCircle(myPen, g ,chain.c_pt, chain.c_pt2);
                    break;

                case (int)Shape.FreeLine:
                    DrawFreeLine(myPen, g, chain.c_pt, chain.c_pt2);
                    break;

                case (int)Shape.Text:       
                    Brush myBrush = new SolidBrush(chain.c_color);
                    DrawText(myBrush, g);
                    break;

                case (int)Shape.ConvertColor: //안고침
                    ConvertColor();
                    break;
                case (int)Shape.Triangle:
                    DrawTriangle(myPen, g, chain.c_pt, chain.c_pt2);
                    break;
                case (int)Shape.Pentagon:
                    DrawPenta(myPen, g, chain.c_pt, chain.c_pt2);
                    break;
                case (int)Shape.Hexagon:
                    DrawHexa(myPen, g, chain.c_pt, chain.c_pt2);
                    break;
                case (int)Shape.Eraser:
                    myPen.Color = Color.White;
                    DrawFreeLine(myPen, g, chain.c_pt, chain.c_pt2);
                    break;
            }
      
          Canvas.Refresh(); 
          
        }

        private void DrawText(Brush myBrush, Graphics g)
        {
            TextDlg myTextDlg = new TextDlg();
            myTextDlg.ShowDialog(this);
            g.DrawString(Contents, myFont, myBrush, Point2);
            Contents = "";
        }

       
        private void ConvertColor()
        {
            Bitmap tempBMP = new Bitmap(Canvas.Image);
            Color tempColor = tempBMP.GetPixel(Point2.X, Point2.Y);
            SourceColor = tempColor;

            ConvertClrDlg myConvertClrDlg = new ConvertClrDlg();
            myConvertClrDlg.ShowDialog(this);

            for (int i = 0; i < tempBMP.Height; i++)
            {
                for (int j = 0; j < tempBMP.Width; j++)
                {
                    if (tempBMP.GetPixel(j, i) == SourceColor)
                    {
                        tempBMP.SetPixel(j, i, TargetColor);
                    }
                }
            }
            Canvas.Image = tempBMP;
        }

        public void NewDocument()
        {
            if (Canvas.Image != null)
            {
                SaveDocument();
            }

            Bitmap newBitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = newBitmap;

            Brush myBrush = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.FillRectangle(myBrush, 0, 0, Canvas.Image.Width, Canvas.Image.Height);

            myColor = Color.Black;
            ColorBtn.BackColor = myColor;
        }

        public void OpenDocument()
        {
            try
            {
                if (Canvas.Image != null)
                {
                    SaveDocument();
                }
                if (OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    Canvas.Image = Image.FromFile(OpenDlg.FileName);

                    list1.Clear();
                    list2.Clear();
                    list4.Clear();
                   
                }
            }
            catch (Exception openE)
            {
                MessageBox.Show(this, "파일을 여는데 오류가 발생하였습니다. : " + openE.Message, "myCanvas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveDocument()
        {
            if (Canvas.Image != null)
            {
                if (MessageBox.Show(this, "저장하시겠습니까?", "myCanvas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (SaveDlg.ShowDialog() == DialogResult.OK)
                    {
                        Canvas.Image.Save(SaveDlg.FileName);
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void menu_File_New_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void menu_File_Open_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void menu_File_Save_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "종료하시겠습니까?", "myCanvas", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        int count_for = 0;
        int count_for_real = 0;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:

                    Point1.X = e.X;
                    Point1.Y = e.Y;
                    break;

                case MouseButtons.Right:

                //    list_mc = list1;

                    list1.Reverse();
                    foreach (Chain chain in list1)
                    {
                       
                        Point3.X = e.X;
                        Point3.Y = e.Y;

                       
                            if (Point3.X >= chain.c_pt.X && Point3.X <= chain.c_pt2.X)
                            {

                                if (Point3.Y >= chain.c_pt.Y && Point3.Y <= chain.c_pt2.Y)
                                {
                                if (count_for == 0)
                                {
                                    count_for_real = 10;
                                    ChainView.Text = ChainView.Text + chain.c_DrawMode;
                                    list_m.AddFirst(chain);

                                    list1.Remove(chain);
                                    count_for++;
                                }
                                    break;
                                //찾은거를 제거하는 방식
                                }
                            }


                    }
                    count_for = 0;

                    break;
            }
           
        }



        private void R_Canvas_MouseDown(Point point_o,Point point_o1,Point point_m, int drawmode)
        {
           
        }



        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    Point2.X = e.X;
                    Point2.Y = e.Y;


                    if (DrawMode != (int)Shape.FreeLine || DrawMode != (int)Shape.Eraser)
                    {
                        Chain chain_use = new Chain();
                        chain_use.c_angle_size = angle_size;
                        chain_use.c_color = myColor;
                        chain_use.c_contents = contents;
                        chain_use.c_DrawMode = DrawMode;
                        chain_use.c_font = myfont;
                        chain_use.c_pt = Point1;
                        chain_use.c_pt2 = Point2;
                        chain_use.c_line_size = line_size;
                        chain_use.c_line_style = line_style;
                        chain_use.c_sourcecolor = sourcecolor;
                        chain_use.c_TargetColor = targetcolor;
                        chain_use.free_line = list_free;
                        list1.AddLast(chain_use);

                        DrawShape(chain_use);
                    }
                    break;
                case MouseButtons.Right:
                    list_m.Clear();
                    if (count_for_real == 10)
                    {
                        list_m.Clear();
                        list1.Reverse();
                        Chain chain_a = new Chain();
                        chain_a.c_angle_size = angle_size;
                        chain_a.c_color = myColor;
                        chain_a.c_contents = contents;
                        chain_a.c_DrawMode = DrawMode;
                        chain_a.c_font = myfont;
                        chain_a.c_pt = Point4;
                        chain_a.c_pt2 = Point5;
                        chain_a.c_line_size = line_size;
                        chain_a.c_line_style = line_style;
                        chain_a.c_sourcecolor = sourcecolor;
                        chain_a.c_TargetColor = targetcolor;

                        list1.AddLast(chain_a);

                        DrawShape(chain_a);
                    }
                    count_for_real = 0;
                    break;
            }
       
           
        }
        int aaz = 0;
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                if (DrawMode == (int)Shape.FreeLine || DrawMode == (int)Shape.Eraser)
                {
                    Point2.X = Point1.X;
                    Point2.Y = Point1.Y;
                    Point1.X = e.X;
                    Point1.Y = e.Y;


                    Chain chain_use = new Chain();
                    chain_use.c_angle_size = angle_size;
                    chain_use.c_color = myColor;
                    chain_use.c_contents = contents;
                    chain_use.c_DrawMode = DrawMode;
                    chain_use.c_font = myfont;
                    chain_use.c_pt = Point1;
                    chain_use.c_pt2 = Point2;
                    chain_use.c_line_size = line_size;
                    chain_use.c_line_style = line_style;
                    chain_use.c_sourcecolor = sourcecolor;
                    chain_use.c_TargetColor = targetcolor;

                    //  list1.Reverse();
                    // list1.AddLast(chain_use);

                    Point_free point_free_use = new Point_free();
                    point_free_use.Point1 = Point1;
                    point_free_use.Point2 = Point2;

                    list_free.AddLast(point_free_use);

                    DrawShape(chain_use);

                }
                else
                {

                    Chain chain_use_rop = new Chain();
                    chain_use_rop.c_angle_size = angle_size;
                    chain_use_rop.c_color = Color.White;
                    chain_use_rop.c_contents = contents;
                    chain_use_rop.c_DrawMode = DrawMode;
                    chain_use_rop.c_font = myfont;
                    chain_use_rop.c_pt = Point1;
                    chain_use_rop.c_pt2 = Point2;
                    chain_use_rop.c_line_size = line_size;
                    chain_use_rop.c_line_style = line_style;
                    chain_use_rop.c_sourcecolor = sourcecolor;
                    chain_use_rop.c_TargetColor = targetcolor;
                    DrawShape(chain_use_rop);
                    //  list4.AddLast(chain_use);

                    Point2.X = e.X;
                    Point2.Y = e.Y;

                    DrawShape(chain_use_rop);
                    chain_use_rop.c_pt2 = Point2;
                    chain_use_rop.c_color = myColor;
                    Hi_Click();
                    DrawShape(chain_use_rop);
                }


            }
            else if (e.Button == MouseButtons.Right)
            {

                Canvas_Clear();
                    foreach (Chain chain in list1)
                    {
                        DrawShape(chain);
                    }

                foreach (Chain chainb in list_m)
                {
                    
                    
                        Point4 = chainb.c_pt;
                        chainb.c_pt.X = e.X;
                        chainb.c_pt.Y = e.Y;
                        chainb.c_pt2.X = chainb.c_pt2.X - Point4.X + chainb.c_pt.X;
                        chainb.c_pt2.Y = chainb.c_pt2.Y - Point4.Y + chainb.c_pt.Y;

                        Point4 = chainb.c_pt;
                        Point5 = chainb.c_pt2;
                        DrawShape(chainb);
                    aaz++;
                    ChainView.Text=aaz.ToString();
                }
          

               


            }
        }

        private void menu_Shape_Line_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Line);
        }

        private void menu_Shape_Rect_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Rect);
        }

        private void menu_Shape_Circle_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Circle);
        }

        private void menu_Shape_Free_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.FreeLine);
        }

        private void menu_Shape_Text_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Text);
        }

        private void menu_Shape_Color_Click(object sender, EventArgs e)
        {
            SetColor();
        }

        private void menu_Shape_Convert_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.ConvertColor);
        }

        private void menu_help_About_Click(object sender, EventArgs e)
        {
            AboutDlg myAboutDlg = new AboutDlg();
            myAboutDlg.ShowDialog(this);
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Line);
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
           SetShape((int)Shape.Rect);
        }

        private void CirceltBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Circle);
        }

        private void FreeBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.FreeLine);
        }

        private void TextBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Text);
        }

        private void ConvertClrBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.ConvertColor);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            SetColor();
        }



        private void toolStripButton1_Click(object sender, EventArgs e) ///polygon 버튼 나중에 이름바꾸기
        {
            Polygon myPoly = new Polygon();
            myPoly.ShowDialog(this);
           
            Polygon(angle_size);
        }


      


        private void polygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polygon myPoly = new Polygon();
            myPoly.ShowDialog(this);

            Polygon(angle_size);
        }

        private void Canvas_Clear()
        {
            Brush myBrush = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.FillRectangle(myBrush, 0, 0, Canvas.Image.Width, Canvas.Image.Height);
            Canvas.Refresh();
        }

       

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            SetShape((int)Shape.Eraser);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Canvas_Clear();
        }

        private void l_width_Click(object sender, EventArgs e)
        {
            Line_setting myLineSetting = new Line_setting();
            myLineSetting.ShowDialog(this);

        }

        public static int aaa = 0;


        private void Hi_Click()
        {
            Canvas_Clear();

            try
            {
                foreach (Chain chain in list1)
                {
   
                    DrawShape(chain);
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, "에러다 고쳐라");
            }
        }
        ///


      


        private void Undo_Click(object sender, EventArgs e)
        {
            Canvas_Clear();

            if (list1.Count == 0)
            {
                MessageBox.Show(this, "더 이상의 돌릴 실수는 남아있지않습니다.");
                return;
            }

            try
            {
                list2.AddFirst(list1.Last.Value); //마지막꺼를 넣어주고
                list1.RemoveLast();         // 마지막꺼는 지워주고
                foreach (Chain chain in list1)
                {
                    if(chain.c_DrawMode == 3)
                    {
                        foreach(Point_free p_f in chain.free_line)
                        {
                            chain.c_pt = p_f.Point1;
                            chain.c_pt2 = p_f.Point2;
                            DrawShape(chain);
                        }
                    }
                    else
                    {
                        DrawShape(chain);
                    }
               
                 
                    
                }
        


            }

            catch (Exception ex)
            {
                MessageBox.Show(this, "에러다 고쳐라");
            }
        }
        private void Redo_Click(object sender, EventArgs e)
        {
            if (list2.Count == 0) {
                MessageBox.Show(this, "원래의 형태입니다.");
                return;

            }

            Canvas_Clear();

            try
            {
                list1.AddLast(list2.First.Value);
                list2.RemoveFirst();

                foreach (Chain chain in list1)
                {
                    if (chain.c_DrawMode == 3)
                    {
                        foreach (Point_free p_f in chain.free_line)
                        {
                            chain.c_pt = p_f.Point1;
                            chain.c_pt2 = p_f.Point2;
                            DrawShape(chain);
                        }
                    }
                    else
                    {
                        DrawShape(chain);
                    }

                  
                }
             
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, "에러다 고쳐라");
            }
        }


  
        public void FormCapture(Size uFormSize, String uFileName)
        {
            Bitmap bitmap = new Bitmap(uFormSize.Width, uFormSize.Height);
            Graphics g = Graphics.FromImage(bitmap);
           g.CopyFromScreen(new Point(this.Bounds.X, this.Bounds.Y), new Point(0, 0), uFormSize);

            bitmap.Save(uFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            
            Screen myScreen = new Screen();
            myScreen.ShowDialog(this);

            Delay(250);

            Size sz = new Size(this.Bounds.Width, this.Bounds.Height);

            FormCapture(sz, FileName);            
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private static string fileName;
        public static string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }

     
    }


}
