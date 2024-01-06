using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public static int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void bluu_Click(object sender, EventArgs e)
        {
            if(int.Parse(tba.Text)*int.Parse(tbnghiem.Text) + int.Parse(tbb.Text) == 0)
            {
                MessageBox.Show("dung");
            }
            else
            {
                MessageBox.Show("sai");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count == 5)
            {
                MessageBox.Show("het gio");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
