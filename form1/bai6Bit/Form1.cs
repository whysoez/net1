using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6Bit
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

        private void bBit_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tN.Text);
            string result = "";
            do
            {
                result = n % 2 + result;
                n = n / 2;
            }
            while (n > 0);
            tBit.Text = result;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
