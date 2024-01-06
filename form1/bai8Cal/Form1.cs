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
        public static int dotCount = 0;
        public Form1()
        {
            InitializeComponent();
            Cal.operation = Operation.Init;
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
            if(dotCount > 0)
            {
                dotCount++;
                double pendDot = double.Parse(append);
                for(int i = 0; i < dotCount; i++)
                {
                    pendDot /= 10;
                }
                //Cal.result += pendDot;
                Cal.resultAppend += pendDot;
            }
            else
            {
                //Cal.result = Cal.result * 10 + double.Parse(append);
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
            //Cal.operation = Operation.Dot;
            dotCount++;
            tResult.Text += ".";
            //ClickGeneric(result.ToString(), sender.Text);
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            CalTotal();
            tResult.Text = "0";
            Cal.resultAppend = 0;
            Cal.operation = Operation.Add;
            dotCount = 0;

        }

        private void CalTotal()
        {
            switch (Cal.operation)
            {
                case Operation.Add:
                    Cal.result += Cal.resultAppend;
                    break;
                case Operation.Sub:
                    Cal.result -= Cal.resultAppend;
                    break;
                case Operation.Multil:
                    Cal.result *= Cal.resultAppend;
                    break;
                case Operation.Devide:
                    Cal.result /= Cal.resultAppend;
                    break;
                case Operation.Equal:
                    tResult.Text = Cal.result.ToString();
                    break;
                default:
                    Cal.result = Cal.resultAppend;
                    break;
            }

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            tResult.Text = "0";
            Cal.result = 0;
            Cal.resultAppend = 0;
            Cal.operation = Operation.Init;
            dotCount = 0;
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            CalTotal();
            tResult.Text = "0";
            Cal.resultAppend = 0;
            Cal.operation = Operation.Sub;
            dotCount = 0;
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            CalTotal();
            tResult.Text = Cal.result.ToString();
            Cal.operation = Operation.Equal;
        }

        private void bSumSub_Click(object sender, EventArgs e)
        {

        }

        private void bMultil_Click(object sender, EventArgs e)
        {
            CalTotal();
            tResult.Text = "0";
            Cal.resultAppend = 0;
            Cal.operation = Operation.Multil;
            dotCount = 0;
        }

        private void bDevide_Click(object sender, EventArgs e)
        {
            CalTotal();
            tResult.Text = "0";
            Cal.resultAppend = 0;
            Cal.operation = Operation.Devide;
            dotCount = 0;
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
        Equal,
        Init,
        Dot
    }
}
