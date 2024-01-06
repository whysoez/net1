using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4Prime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string result = "";
            int n = int.Parse(tN.Text);
            for(int i = 2; i <= n; i++)
            {
                bool check = false;
                for(int j = 2; j < i; j++)
                {
                    if(i%j == 0)
                        check = true;
                }
                if (!check)
                    result += i.ToString() + " ";
            }
            tSmallN.Text = result;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tSmallN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
