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

namespace QuanLyDocGia
{
    public partial class QuanLyDocGia : Form
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
            InitData();
        }

        private void bookName_Click(object sender, EventArgs e)
        {

        }

        private void dGBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {

        }
    }
}
