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
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
            InitData();
        }

        private void dGReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitData()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LibrarySystem;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from table_reader", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtBook = new DataTable();
                dtBook.Load(reader);
                dGReader.DataSource = dtBook;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void breaderBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
