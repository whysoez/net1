using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Login : Form
    {

        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LibrarySystem;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
            con.Open();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        }

        private void bLoginExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPass forgotPass = new ForgotPass();
            forgotPass.Show();
        }
    }
}
