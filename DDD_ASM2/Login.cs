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
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            createConnection();
        }
        private void createConnection()
        {
            try
            {
                String stringConnection = "Data Source=DESKTOP-SEN86E8\\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True;";
                conn = new SqlConnection(stringConnection);
                MessageBox.Show("Database connection successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in createConnection" + ex.Message);
            }
            conn.Close();

        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            String username = txt_user.Text;
            String password = txt_pass.Text;

            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            String sql = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password ='" + password + "'";

            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Appdata.isLogined = true;
                Appdata.name = reader["Username"].ToString();
                if (reader["RolesId"].ToString() == "1")
                {
                    Appdata.isAdmin = true;
                    MessageBox.Show(Appdata.name + " is Admin");
                }
                else
                {
                    MessageBox.Show(Appdata.name + " is not Admin");

                }
                Close();

            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm closing the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }
    }
}
