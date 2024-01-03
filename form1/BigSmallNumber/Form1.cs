using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigSmallNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (max, min) = Cal();
            textBoxBig.Text = max.ToString();
            textBoxSmall.Text = min.ToString();
        }

        private (int, int) Cal()
        {
            var arr = new int[]
            {
                int.Parse(textBoxA.Text),
                int.Parse(textBoxB.Text),
                int.Parse(textBoxC.Text)
            };
            return (arr.Max(), arr.Min());
        }
    }
}
