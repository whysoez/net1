using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
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

        private void but1_Click(object sender, EventArgs e)
        {
            tthanhTien.Text = (int.Parse(tsoLuong.Text)*int.Parse(tdonGia.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ttenHang.Text = "";
            tsoLuong.Text = "";
            tdonGia.Text = "";
            tthanhTien.Text = "";
            ttenHang.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tthanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeric_valid(object sender, CancelEventArgs e)
        {
            int n;
            var isnumeric = int.TryParse(tsoLuong.Text, out n);
            if (!isnumeric)
            {
                esoLuong.SetError(tsoLuong, "so luong phải là số");
            }
            else
            {
                esoLuong.SetError(tsoLuong, string.Empty);
            }
        }

        private void edongia_valid(object sender, CancelEventArgs e)
        {
            int n;
            var isnumeric = int.TryParse(tdonGia.Text, out n);
            if (!isnumeric)
            {
                edonGia.SetError(tdonGia, "đơn giá phải là số");
            }
            else
            {
                edonGia.SetError(tdonGia, string.Empty);
            }
        }
    }
}
