using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalFraction
{
    public partial class Form1 : Form
    {
        public static Operation operation { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int tu1 = int.Parse(tTu1.Text.Trim());
            int mau1 = int.Parse(tMau1.Text.Trim());
            int tu2 = int.Parse(tTu2.Text.Trim());
            int mau2 = int.Parse(tMau2.Text.Trim());
            int ucln = Ucln(mau1, mau2);

            switch (operation)
            {
                case Operation.sum:
                    {
                        tTu.Text = ((tu1*mau2 + tu2*mau1)/ucln).ToString();
                        tMau.Text = ((mau1*mau2)/ucln).ToString();
                        break;
                    }
                case Operation.sub:
                    {
                        tTu.Text = ((tu1 * mau2 - tu2 * mau1) / ucln).ToString();
                        tMau.Text = ((mau1 * mau2) / ucln).ToString();
                        break;
                    }
                case Operation.multil:
                    {
                        var uclnTemp = Ucln(tu1*tu2, mau1* mau2);
                        tTu.Text = (tu1*tu2/uclnTemp).ToString();
                        tMau.Text = (mau1*mau2/uclnTemp).ToString();
                        break;
                    }
                case Operation.devide:
                    {
                        var uclnTemp = Ucln(tu1*mau2, tu2*mau1);
                        tTu.Text = (tu1 * mau2 / uclnTemp).ToString();
                        tMau.Text = (mau1 * tu2 / uclnTemp).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bSum_Click(object sender, EventArgs e)
        {
            operation = Operation.sum;

        }

        private void bSub_Click(object sender, EventArgs e)
        {
            operation = Operation.sub;
        }

        private void bMutil_Click(object sender, EventArgs e)
        {
            operation = Operation.multil;
        }

        private void bDevide_Click(object sender, EventArgs e)
        {
            operation = Operation.devide;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int Ucln(int a, int b)
        {
            int result = 0;
            for (int i = 1; i <= (a < b ? a : b); i++)
            {
                if (a % i == 0 && b % i == 0)
                    result = i;
            }
            return result;
        }
    }

    public enum Operation
    {
        sum,
        sub,
        multil,
        devide
    }

    public class Fraction
    {
        int num { get; set; }
        int ben { get; set; }
        public Fraction(int num, int ben)
        {
            this.num = num;
            this.ben = ben; 
        }


    }
}
