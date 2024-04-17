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
    public partial class User : Form
    {
        string connectionString = "Data Source=DESKTOP-SEN86E8\\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True";
        SqlConnection con;
        public User()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }
        public void FillGrid()
        {
            string query = "select * from Users";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgv_list_user.DataSource = table;
            con.Close();

        }

        private void User_Load(object sender, EventArgs e)
        {
            FillGrid();
            //btn_add.Enabled = true;
            //btn_update.Enabled = false;
        }
        private void btn_home_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            string uid = txt_userId.Text;
            string uname = txt_username.Text;
            string pass = txt_pass.Text;
            string dob = txt_dob.Text;
            string clas = txt_class.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string roles = txt_roles.Text;
            string add = "insert into Users values ('" + uid + "','" + uname + "','" + pass + "','" + dob + "','" + clas + "','" + email + "','" + phone + "','" + roles + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(add, con); //dùng để thực hiện
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            FillGrid();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string uid = txt_userId.Text;
            string uname = txt_username.Text;
            string pass = txt_pass.Text;
            string dob = txt_dob.Text;
            string clas = txt_class.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string roles = txt_roles.Text;
            string update = "Update Users  SET Username= '" + uname + "',Password='" + pass + "',DoB= '" + dob + "',Class= '" + clas + "',Email= '" + email + "',Phone= '" + phone + "',RolesId= '" + roles + "' where UserID= '" + uid + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            FillGrid();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("DO YOU WANT TO DELETE ?", "Confirmation", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                string uid = txt_userId.Text;
                string uname = txt_username.Text;
                string pass = txt_pass.Text;
                string dob = txt_dob.Text;
                string clas = txt_class.Text;
                string email = txt_email.Text;
                string phone = txt_phone.Text;
                string roles = txt_roles.Text;
                string delete = "Delete from Users where UserID='" + uid + "' ";
                con.Open();
                SqlCommand cmd1 = new SqlCommand(delete, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                con.Close();
                FillGrid();
            }
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_userId.Clear();
            txt_username.Clear();
            txt_pass.Clear();
            txt_dob.Clear();
            txt_class.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_roles.Clear();

        }

        private void dgv_list_user_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_list_user.Rows[e.RowIndex];
                txt_userId.Text = row.Cells["UserID"].Value.ToString();
                txt_username.Text = row.Cells["Username"].Value.ToString();
                txt_pass.Text = row.Cells["Password"].Value.ToString();
                txt_dob.Text = row.Cells["DoB"].Value.ToString();
                txt_class.Text = row.Cells["Class"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_phone.Text = row.Cells["Phone"].Value.ToString();
                txt_roles.Text = row.Cells["ROlesId"].Value.ToString();
                txt_userId.Enabled = false;
            }
        }
    }
}
