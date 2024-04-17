using DDD_ASM2;
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

namespace AttendanceManagement
{
    public partial class Attendance : Form
    {
        string connectionString = "Data Source=DESKTOP-SEN86E8\\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True";
        SqlConnection con;
        public Attendance()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        public void FillGrid()
        {
            string query = "select * from Attandances";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgv_list_attendance.DataSource = table;
            con.Close();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string aid = txt_Id.Text;
            string userid = txt_userId.Text;
            string courseid = txt_courseId.Text;
            string dob = txt_date.Text;
            string status = txt_status.Text;
            string add = "insert into Attandances values ('" + aid + "','" + userid + "','" + courseid + "','" + dob + "','" + status + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(add, con); //dùng để thực hiện
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            FillGrid();
        }

        private void AttendanceManagement_Load(object sender, EventArgs e)
        {
            FillGrid();
            btn_Add.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string aid = txt_Id.Text;
            string userid = txt_userId.Text;
            string courseid = txt_courseId.Text;
            string dob = txt_date.Text;
            string status = txt_status.Text;
            string update = "Update Attandances  SET UserID= '" + userid + "',CourseID='" + courseid + "',ADate= '" + txt_date + "',AStatus= '" + status + "' where ID= '" + aid + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            FillGrid();
        }
        private void btn_home_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string aid = txt_Id.Text;
            string userid = txt_userId.Text;
            string courseid = txt_courseId.Text;
            string dob = txt_date.Text;
            string status = txt_status.Text;
            string update = "Update Attandances  SET UserID= '" + userid + "',CourseID='" + courseid + "',ADate= '" + txt_date + "',AStatus= '" + status + "' where ID= '" + aid + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            FillGrid();
        }

        private void dgv_list_attendance_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_list_attendance.Rows[e.RowIndex];
                txt_Id.Text = row.Cells["ID"].Value.ToString();
                txt_userId.Text = row.Cells["UserID"].Value.ToString();
                txt_courseId.Text = row.Cells["CourseID"].Value.ToString();
                txt_date.Text = row.Cells["ADate"].Value.ToString();
                txt_status.Text = row.Cells["Status"].Value.ToString();
                txt_Id.Enabled = false;

            }
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("DO YOU WANT TO DELETE ?", "Confirmation", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                string aid = txt_Id.Text;
                string userid = txt_userId.Text;
                string courseid = txt_courseId.Text;
                string dob = txt_date.Text;
                string status = txt_status.Text;
                string delete = "Delete from Attandances where ID='" + aid + "' ";
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
            txt_Id.Clear();
            txt_date.Clear();
            txt_status.Clear();
        }
    }
}
