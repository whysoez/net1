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

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tbdiem.Text + "/n" + tbngaysinh.Text + "/n" + tbten.Text);
        }

        private void tbngaysinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime pass;
            int diem;
            if (!(DateTime.TryParseExact(tbngaysinh.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture
                , DateTimeStyles.None, out pass)))
            {
                engaysinh.SetError(tbngaysinh, "ngay sinh sai dinh dang");
            }
            else
            {
                engaysinh.SetError(tbngaysinh, string.Empty);
            }
            if(!(int.TryParse(tbdiem.Text, out diem)))
            {
                ediem.SetError(tbdiem, "diem la so");
            }
            else
            {
                ediem.SetError(tbdiem, string.Empty);
            }

        }

        private void button1_Validated(object sender, EventArgs e)
        {
            //DateTime pass;
            //int diem;
            //if (DateTime.TryParseExact(tbngaysinh.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture
            //    , DateTimeStyles.None, out pass))
            //{
            //    engaysinh.SetError(tbngaysinh, "ngay sinh sai dinh dang");
            //}
            //else
            //{
            //    engaysinh.SetError(tbngaysinh, string.Empty);
            //}
            //if (int.TryParse(tbdiem.Text, out diem))
            //{
            //    ediem.SetError(tbdiem, "diem la so");
            //}
            //else
            //{
            //    ediem.SetError(tbdiem, string.Empty);
            //}
        }

        private void tbdiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbten_TextChanged(object sender, EventArgs e)
        {
            DateTime pass;
            int diem;
            if (!(DateTime.TryParseExact(tbngaysinh.Text, "mm/dd/yyyy", CultureInfo.InvariantCulture
                , DateTimeStyles.None, out pass)))
            {
                engaysinh.SetError(tbngaysinh, "ngay sinh sai dinh dang");
            }
            else
            {
                engaysinh.SetError(tbngaysinh, string.Empty);
            }
            if (!(int.TryParse(tbdiem.Text, out diem)))
            {
                ediem.SetError(tbdiem, "diem la so");
            }
            else
            {
                ediem.SetError(tbdiem, string.Empty);
            }
        }
    }
}
