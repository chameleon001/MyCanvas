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
    public partial class ConvertClrDlg : Form
    {
        public ConvertClrDlg()
        {
            InitializeComponent();
        }

        private void ConvertClrDlg_Load(object sender, EventArgs e)
        {
            SrcClrBox.BackColor = MainForm.SourceColor;
        }

        private void TrgClrBox_Click(object sender, EventArgs e)
        {
            if(ColorDlg.ShowDialog(this) == DialogResult.OK)
            {
                TrgClrBox.BackColor = ColorDlg.Color;
                MainForm.TargetColor = ColorDlg.Color;
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
