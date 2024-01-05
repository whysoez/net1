using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bmenuLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void bmenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void breaderManager_Click(object sender, EventArgs e)
        {
            this.Close();
            Reader reader = new Reader();
            reader.Show();
        }

        private void bBookManager_Click(object sender, EventArgs e)
        {
            this.Close();
            QuanLySach book = new QuanLySach();
            book.Show();
        }

        private void bBorrowManager_Click(object sender, EventArgs e)
        {
            this.Close();
            Borrow borrow = new Borrow();
            borrow.Show();
        }
    }
}
