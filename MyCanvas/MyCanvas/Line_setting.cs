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
    public partial class Line_setting : Form
    {
        int return_style = 0;
        public Line_setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (linesizetext.Text == "")
            {
                MessageBox.Show(this, "선 굵기를 지정해주세요");


            }else if (return_style == 6)
            {
                MessageBox.Show(this, "선 스타일을 지정해주세요");
            }
            else
            {
                MainForm.LineSize = int.Parse(linesizetext.Text);
                MainForm.LineStyle = select_item(sender, e);

                Close();
            }
        }



        private int select_item(object sender, EventArgs e)
        {

            switch (Line_style.SelectedItem.ToString())
            {
                case "Dash":
                    return_style = 1;
                    break;
                case "DashDot":
                    return_style = 2;
                    break;
                case "DashDotDot":
                    return_style = 3;
                    break;
                case "Dot":
                    return_style = 4;
                    break;
                case "Solid":
                    return_style = 5;
                    break;
                default:
                    return_style = 6;
                    break;



            }
            return return_style;
        }
    }

    
}
