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

namespace DDD_ASM2
{
    public partial class SearchStudent : Form
    {
        string connectionString = "Data Source=DESKTOP-SEN86E8\\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True";
        SqlConnection con;
        public SearchStudent()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        private void SearchUser(string keyword)
        {
            string query = "SELECT * FROM Users WHERE Username LIKE @keyword OR Email LIKE @keyword";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

            try
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_list_search.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchUser(txt_search.Text);//btn_search
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
