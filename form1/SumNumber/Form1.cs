using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tSequenn = "";
            int sum = 0;
            for(int i = 1; i <= int.Parse(tN.Text); i++)
            {
                sum += i;
                tSequenn += i.ToString() + "+";
            }
            tSenquen.Text = tSequenn.Trim('+');
            tSum.Text = sum.ToString();
        }
    }
}
