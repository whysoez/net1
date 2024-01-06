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
        public string passShow = "";
        public Boolean check = true;
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
            hProvider.HelpNamespace = "http://phunutoday.vn/kham-pha-cong-nghe/cac-nguyen-tactao-mat-khau-an-toan-33828.html"; ;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tbUserName.Text.Length <= 0)
            {
                epUserName.SetError(tbUserName, "Username not empty");
            }
            else if (tbUserName.Text.IndexOf(' ') != -1)
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
            try
            {
                if (cbshowPass.Checked)
                {
                    //var text = tbPassword.Text.Substring(tbPassword.Text.Length -1, tbPassword.Text.Length);
                    //passShow = passShow + text;
                    passShow = tbPassword.Text;
                    tbPassword.Text = passShow;
                }
                else
                {
                    if (tbPassword.Text.Length == 0)
                    {
                        passShow = tbPassword.Text;
                    }
                    else
                    {
                        if (check)
                            passShow = passShow + tbPassword.Text[tbPassword.Text.Length - 1];
                        string passHide = "";
                        for (int i = 0; i < tbPassword.Text.Length; i++)
                        {
                            passHide += "*";
                        }
                        check = !check;
                        tbPassword.Text = passHide;
                        tbPassword.Select(tbPassword.Text.Length, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                //epPassword.SetError(tbPassword, ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text == "admin" && passShow == "123456")
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Không đăng nhập thành công");
            }
        }

        private void cbshowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowPass.Checked)
            {
                //if (check)
                //    passShow = tbPassword.Text;
                tbPassword.Text = passShow;
                check = false;
            }
            else
            {
                string passHide = "";
                for (int i = 0; i < tbPassword.Text.Length; i++)
                {
                    passHide += "*";
                }
                tbPassword.Text = passHide;
                check = true;
            }
        }
    }
}
