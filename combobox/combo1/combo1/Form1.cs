using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo1
{
    public partial class tResult : Form
    {
        public tResult()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = double.Parse(tA.Text);
            var b = double.Parse(tB.Text);
            var op = cOperator.SelectedItem;
            switch (op)
            {
                case "+":
                    {
                        tRe.Text = (a + b).ToString();
                        break;
                    }
                case "-":
                    {
                        tRe.Text = (a - b).ToString();
                        break;
                    }
                case "*":
                    {
                        tRe.Text = (a*b).ToString();
                        break;
                    }
                case "/":
                    { 
                        tRe.Text = (a/b).ToString();
                        break;
                    }
                default:
                    {
                        tRe.Text = "Operator invalid";
                        break;
                    }
            }
        }
    }
}
