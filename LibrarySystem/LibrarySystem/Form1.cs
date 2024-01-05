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
    public partial class QuanLySach : Form
    {
        public static DataSet dsBook = new DataSet();
        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=LibrarySystem;Integrated Security=True; MultipleActiveResultSets=true");
        public QuanLySach()
        {
            InitializeComponent();
            InitData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InitData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from table_book", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dtBook = new DataTable();
                dtBook.Load(reader);
                dGBook.DataSource = dtBook;

                string queryStringAuthor = @"select AuthorId,Author_Name from table_author";
                cmd.CommandText = queryStringAuthor;
                var author = cmd.ExecuteReader();
                Dictionary<int, string> authorData = new Dictionary<int, string>();
                cbFilterAuthor.Items.Clear();
                cbAuthor.Items.Clear();
                while (author.Read())
                {
                    authorData.Add((int)author[0], author[1].ToString());
                    cbAuthor.Items.Add(author[1].ToString());
                    cbFilterAuthor.Items.Add(author[1].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dGBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tBookName.Text = "aaaaa";
        }


        private void QuanLySach_Load(object sender, EventArgs e)
        {

        }

        private void bBookBack_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void bCreateBook_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string queryStringAuthor = @"select AuthorId,Author_Name from table_author";
                cmd.CommandText = queryStringAuthor;
                var author = cmd.ExecuteReader();
                Dictionary<int, string> authorData = new Dictionary<int, string>();
                cbAuthor.Items.Clear();
                while (author.Read())
                {
                    authorData.Add((int)author[0], author[1].ToString());
                    cbAuthor.Items.Add(author[1].ToString());
                }
                author.Close();
                string queryString = @"insert into table_book (BookTitle, PublisherName, BookType, Price, PublisherTime, BookLanguage, Author, DeadlineTime, BookCount, BookDelete) values (
                                    @BookTitle, @PublisherName, @BookType, @Price, @PublisherTime, @BookLanguage, @Author, @DeadlineTime, @BookCount, 0)";
                cmd.CommandText = queryString;
                cmd.Parameters.AddWithValue("@BookTitle", tBookName.Text);
                cmd.Parameters.AddWithValue("@PublisherName", tPushliserName.Text);
                cmd.Parameters.AddWithValue("@BookType", (int)Enum.Parse(typeof(bookTypeEnum), cbBookType.Text));
                cmd.Parameters.AddWithValue("@Price", nPrice.Value);
                cmd.Parameters.AddWithValue("@PublisherTime", dtPublisherTime.Value.Date);
                cmd.Parameters.AddWithValue("@BookLanguage", (int)Enum.Parse(typeof(languageEnum), cbBookLanguge.Text));
                cmd.Parameters.AddWithValue("@Author", authorData.FirstOrDefault(x => x.Value == cbAuthor.Text).Key);
                cmd.Parameters.AddWithValue("@DeadlineTime", nDeadlineTime.Value);
                cmd.Parameters.AddWithValue("@BookCount", nBookCount.Value);
                cmd.ExecuteNonQuery();
                bRefreshData_Click(sender, e);
            }
            catch (Exception ex)
            {

            }
            
        }

        private void bUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                string queryString = @"update table_book set BookTitle = @BookTitle, PublisherName = @PublisherName, BookType = @BookType, Price = @Price, PublisherTime = @PublisherTime,
                                        BookLanguage = @BookLanguage, Author = @Author, DeadlineTime = @DeadlineTime, BookCount = @BookCount, BookDelete = @BookDelete
                                        where BookId = @BookId";
                cmd.CommandText = queryString;
                cmd.Connection = con;

                var rowCurrent = dGBook.CurrentRow.Cells;

                cmd.Parameters.AddWithValue("@BookTitle", rowCurrent["BookTitle"].Value.ToString());
                cmd.Parameters.AddWithValue("@PublisherName", rowCurrent["PublisherName"].Value.ToString());
                cmd.Parameters.AddWithValue("@BookType", int.Parse(rowCurrent["BookType"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Price", int.Parse(rowCurrent["Price"].Value.ToString()));
                cmd.Parameters.AddWithValue("@PublisherTime", rowCurrent["PublisherTime"].Value);
                cmd.Parameters.AddWithValue("@BookLanguage", int.Parse(rowCurrent["BookLanguage"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Author", int.Parse(rowCurrent["Author"].Value.ToString()));
                cmd.Parameters.AddWithValue("@DeadlineTime", int.Parse(rowCurrent["DeadlineTime"].Value.ToString()));
                cmd.Parameters.AddWithValue("@BookCount", int.Parse(rowCurrent["BookCount"].Value.ToString()));
                cmd.Parameters.AddWithValue("@BookDelete", (Boolean)rowCurrent["BookDelete"].Value ? 1 : 0);
                cmd.Parameters.AddWithValue("@BookId", rowCurrent["BookId"].Value);
                cmd.ExecuteNonQuery();
                bRefreshData_Click(sender, e);
            }
            catch (Exception ex)
            {

            }
        }

        private void bRefreshData_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from table_book", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dtBook = new DataTable();
            dtBook.Load(reader);
            dGBook.DataSource = dtBook;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        public enum languageEnum
        {
             Vietnamese,
             English,
             Chinese
        }
        public enum bookTypeEnum
        {
            daicuong,
            chuyennganh,
            tieuthuyet
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbFilterAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bFilterBook_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string queryStringAuthor = @"select AuthorId,Author_Name from table_author";
            cmd.CommandText = queryStringAuthor;
            var author = cmd.ExecuteReader();
            Dictionary<int, string> authorData = new Dictionary<int, string>();
            while (author.Read())
            {
                authorData.Add((int)author[0], author[1].ToString());
            }
            author.Close();

            string queryString = @"select * from table_book where 1 = 1";
            //if(authorData.FirstOrDefault(x => x.Value == cbAuthor.Text).Key)

            if (!string.IsNullOrEmpty(cbFilterBookLanguage.Text))
            {
                queryString += " and BookLanguage = @BookLanguage";
                cmd.Parameters.AddWithValue("@BookLanguage", (int)Enum.Parse(typeof(languageEnum), cbFilterBookLanguage.Text));
            }
            if (!string.IsNullOrEmpty(cbFilterAuthor.Text))
            {
                queryString += " and Author = @BookAuthor";
                cmd.Parameters.AddWithValue("@BookAuthor", authorData.FirstOrDefault(x => x.Value == cbFilterAuthor.Text).Key);
            }
            if (!string.IsNullOrEmpty(cbFilterBookType.Text))
            {
                queryString += " and BookType = @BookType";
                cmd.Parameters.AddWithValue("@BookType", (int)Enum.Parse(typeof(bookTypeEnum), cbFilterBookType.Text));
            }
            cmd.CommandText = queryString;
            var dataFilter = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dataFilter);
            dGBook.DataSource = dt;
        }

        private void bSearchBook_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string queryString = @"select * from table_book where BookTitle like '%" + tSearchBook.Text + "%'";
            cmd.CommandText = queryString;
            //cmd.Parameters.AddWithValue("@BookTitle", tSearchBook.Text ?? "");
            var dt = cmd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dt);
            dGBook.DataSource = data;
        }

        private void bDeleteBook_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            string queryString = @"delete table_book where BookId = @BookId";
            cmd.CommandText = queryString;
            var bookId = dGBook.CurrentRow.Cells["BookId"].Value;
            cmd.Parameters.AddWithValue("@BookId", bookId);
            cmd.ExecuteNonQuery();
            bRefreshData_Click(sender, e);
        }
    }

}
