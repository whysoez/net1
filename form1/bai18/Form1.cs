using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace bai18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = {thodem.Text, tten.Text, tbsdt.Text};
            ListViewItem listview1 = new ListViewItem(row);
            listView1.Items.Add(listview1);
        }

        private void thodem_Validating(object sender, CancelEventArgs e)
        {
            string hodem = "";
            if (thodem.Text.Length == 0)
            {
                ehodem.SetError(thodem, "họ đệm không được để trống");
            }
            else
            {
                ehodem.SetError(thodem, string.Empty);
            }
        }

        private void tten_Validating(object sender, CancelEventArgs e)
        {
            string ten = "";
            if (tten.Text.Length == 0)
            {
                ehodem.SetError(tten, "tên không được để trống");
            }
            else
            {
                ehodem.SetError(tten, string.Empty);
            }
        }

        private void tbsdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
