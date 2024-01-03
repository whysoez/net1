using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = lb.Items;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            lb.Items.Add(tText.Text);
            tText.Text = "";
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem.ToString());
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
