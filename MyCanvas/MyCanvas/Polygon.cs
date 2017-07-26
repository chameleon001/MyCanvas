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
    public partial class Polygon : Form
    {
        public Polygon()
        {
            InitializeComponent();
        }

        private void tri_b_Click(object sender, EventArgs e)
        {
            MainForm.AngleSize = 3;
            Close();
        }

        private void rect_b_Click(object sender, EventArgs e)
        {
            MainForm.AngleSize = 4;
            Close();
        }

        private void pent_b_Click(object sender, EventArgs e)
        {
            MainForm.AngleSize = 5;
            Close();
        }

        private void Hexa_b_Click(object sender, EventArgs e)
        {
            MainForm.AngleSize = 6;
            Close();
        }
    }

    ///
    ///  추가된것들 나중에 정리
    ///
    ///
   

}
