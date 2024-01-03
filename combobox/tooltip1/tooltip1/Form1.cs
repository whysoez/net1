using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tooltip1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ttUserName.SetToolTip(tbUserName, "Enter Username not exist space");
            ttPassword.SetToolTip(tbPassword, "Enter Password not exist special keywords");

            hProvider.SetShowHelp(tbUserName, true);
            hProvider.SetShowHelp(tbPassword, true);
            hProvider.HelpNamespace ="http://phunutoday.vn/kham-pha-cong-nghe/cac-nguyen-tactao-mat-khau-an-toan-33828.html"; ;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if(tbUserName.Text.Length <= 0)
            {
                epUserName.SetError(tbUserName, "Username not empty");
            }
            else if(tbUserName.Text.IndexOf(' ') != -1)
            {
                epUserName.SetError(tbUserName, "Username not exist space");
            }
            else
            {
                epUserName.Clear();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            long check = 0;
            try
            {
                check = Convert.ToInt64(tbPassword.Text);
                epPassword.Clear();
            }
            catch(Exception ex)
            {
                epPassword.SetError(tbPassword, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login");
        }
    }
}
