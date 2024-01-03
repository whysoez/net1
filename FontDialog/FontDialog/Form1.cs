using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialog
{
    public partial class formD : Form
    {
        public formD()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bChoiceColor_Click(object sender, EventArgs e)
        {
            DialogResult rs = colorDialog1.ShowDialog();
            if(rs == DialogResult.OK)
            {
                tbTitle.BackColor = colorDialog1.Color;
            }
        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void bChoiceFont_Click(object sender, EventArgs e)
        {
            DialogResult rs = fontDialog2.ShowDialog();
            if(rs == DialogResult.OK)
            {
                tbTitle.Font = fontDialog2.Font;
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
