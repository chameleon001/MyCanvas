using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace MyCanvas
{
    class Chain
    {
    
            public Color c_color;
            public Point c_pt, c_pt2, c_pt3, c_pt4; // 여분으로 여러개 선언
            public Point c_f_pt1, c_f_pt2, c_f_pt3;//프리드로우용 여러개 미리선언
            public int c_DrawMode;
            public Font c_font;
            public Color c_TargetColor, c_sourcecolor;
            public string c_contents; //글자 텍스트 넣는 거 저장

            public int c_line_style;
            public int c_angle_size;
            public int c_line_size = 3;
        public Point[] abc;
        public LinkedList<Point_free> free_line;
     
    }
}
