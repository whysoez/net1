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

namespace QuanLyMuonSach
{
    public partial class QuanLyMuonSach : Form
    {
        public QuanLyMuonSach()
        {
            InitializeComponent();
            InitData();
        }

        private void QuanLyMuonSach_Load(object sender, EventArgs e)
        {

        }

        private void dGBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitData()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LibrarySystem;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from table_borrow", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtBook = new DataTable();
                dtBook.Load(reader);
                dGBorrow.DataSource = dtBook;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
