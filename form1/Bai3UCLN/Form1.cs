using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3UCLN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bRun_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tA.Text);
            int b = int.Parse(tB.Text);
            var ucln = Ucln(a, b);
            tUcln.Text = ucln.ToString();
            tBcnn.Text = (a * b / ucln).ToString();
        }

        private int Ucln(int a, int b)
        {
            int result = 0;
            for(int i = 1; i <= (a<b?a:b); i++)
            {
                if(a%i == 0 && b%i == 0)
                    result = i;
            }
            return result;
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            tA.Text = tB.Text = tBcnn.Text = tUcln.Text = "";

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
