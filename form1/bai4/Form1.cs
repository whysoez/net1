using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bhien_Click(object sender, EventArgs e)
        {
            if (rbdo.Checked)
            {
                tbcontent.ForeColor = Color.Red;
            }
            if (rbxanh.Checked)
            {
                tbcontent.ForeColor = Color.Green;
            }
            if (rbDen.Checked)
            {
                tbcontent.ForeColor = Color.Black;
            }
            FontStyle style = FontStyle.Regular;
            if (cdam.Checked)
            {
                style = style | FontStyle.Bold;
            }
            if (cnghieng.Checked)
            {
                style = style | FontStyle.Italic;
            }
            if (cgach.Checked)
            {
                style = style | FontStyle.Underline;
            }
            tbcontent.Font = new Font(tbcontent.Font, style);
        }

        private void bthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bxoa_Click(object sender, EventArgs e)
        {
            rbDen.Checked = false;
            rbdo.Checked = false;
            rbxanh.Checked = false;
            cgach.Checked = false;
            cnghieng.Checked = false;
            cdam.Checked = false;

        }
    }
}
