using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbResult.Items.Add(tbAdd.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbResult.Items.Contains(tbSearch.Text))
            {
                MessageBox.Show("exist at index: " + lbResult.FindString(tbSearch.Text));
            }
            else
            {
                MessageBox.Show("not Exist");
            }
        }
    }
}
