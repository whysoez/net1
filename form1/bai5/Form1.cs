using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbn.Text);
            if (rb1.Checked)
            {
                tbketqua.Text = TongSo(n).ToString();
            }
            if (rbmu.Checked)
            {
                tbketqua.Text = TongMu(n).ToString();
            }
            if (rbnghich.Checked)
            {
                tbketqua.Text = TongNghich(n).ToString();
            }
            if (rbgiaithua.Checked)
            {
                tbketqua.Text = TongGiaiThua(n).ToString();
            }
        }
        private double TongSo(int n)
        {
            double sum = 0;
            for(int i = 1; i < n+1; i++)
            {
                sum += (2 * i - 1);
            }
            return sum;
        }
        private double TongMu(int n)
        {
            double sum = 0;
            for(int j = 1; j < n+1; j++)
            {
                sum += j * j;
            }
            return sum;
        }
        private double TongNghich(int n)
        {
            double sum = 0;
            for(int k = 1; k < n+1; k++)
            {
                sum += 1.0 / k;
            }
            return sum;
        }
        private double TongGiaiThua(int n)
        {
            double sum = 0;
            for( int k = 1; k < n+1; k++)
            {
                double mau = 1;
                for( int j = 1; j < k+1; j++)
                {
                    mau *= j;
                }
                sum += 1.0/mau;
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
