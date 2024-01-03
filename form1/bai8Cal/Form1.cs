using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8Cal
{
    public partial class Form1 : Form
    {
        public static double result = 0;
        public static double resultTemp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b0_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void button12_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private string ClickGeneric(string result, string append)
        {
            if(Cal.operation == Operation.Dot)
            {
                Cal.result += double.Parse(append) / 10;
                Cal.resultAppend += double.Parse(append) / 10;
            }
            else
            {
                Cal.result = Cal.result * 10 + double.Parse(append);
                Cal.resultAppend = Cal.resultAppend * 10 + double.Parse(append);
            }
            tResult.Text = Cal.Append().ToString();
            return result + append;
        }

        private void b2_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b3_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b4_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b5_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b6_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b7_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b8_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void b9_Click(dynamic sender, EventArgs e)
        {
            ClickGeneric(result.ToString(), sender.Text);
        }

        private void bDot_Click(dynamic sender, EventArgs e)
        {
            Cal.operation = Operation.Dot;
            //ClickGeneric(result.ToString(), sender.Text);
        }
    }

    public class Cal
    {
        public static double result { get; set;}
        public static double resultAppend { get; set;}
        public static Operation operation { get; set;}
        public Cal(double result1)
        {
            result = result1;
        }

        public static double Append()
        {
            return resultAppend;
        }
    }

    public enum Operation
    {
        Add,
        Sub,
        Multil,
        Devide,
        Dot
    }
}
