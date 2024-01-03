using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2ListBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb.Items.RemoveAt(lb.Items.Count - 1);
            lb.Items.RemoveAt(0);
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            lb.Items.Add(tN.Text);
            tN.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < lb.Items.Count; i++)
            {
                sum += int.Parse(lb.Items[i].ToString());
            }
            tN.Text = sum.ToString();
        }

        private void bRemoveSelected_Click(object sender, EventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem);
        }

        private void bUp2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int item = int.Parse(lb.Items[i].ToString());
                lb.Items.RemoveAt(0);
                lb.Items.Add((item + 2).ToString());
            }
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int item = int.Parse(lb.Items[i].ToString());
                lb.Items.RemoveAt(0);
                lb.Items.Add((item*item).ToString());
            }
        }

        private void bEven_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int item = int.Parse(lb.Items[i].ToString());
                if(item %2 != 0)
                {
                    lb.Items.Remove(item.ToString());
                    i--;
                }
            }
           
        }

        private void bOdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
                int item = int.Parse(lb.Items[i].ToString());
                if (item % 2 == 0)
                {
                    lb.Items.Remove(item.ToString());
                    i--;
                }
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
        }
    }
}
