using DDD_ASM2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendanceManagement
{
    public partial class Course : Form
    {
        string connectionString = "Data Source=DESKTOP-SEN86E8\\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True;";
        SqlConnection con;
        public Course()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        public void FillGrid()
        {
            string query = "select * from Courses";
            con.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(table);
            dgv_list_course.DataSource = table;
            con.Close();

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string cid = txt_courseId.Text;
            string cname = txt_course_name.Text;
            string cstatus = txt_status.Text;
            string add = "insert into Courses values ('" + cid + "','" + cname + "','" + cstatus + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(add, con); //dùng để thực hiện
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            FillGrid();
        }
        private void btn_Add_Click1(object sender, EventArgs e)
        {
            string cid = txt_courseId.Text;
            string cname = txt_course_name.Text;
            string cstatus = txt_status.Text;
            string add = "insert into Courses values ('" + cid + "','" + cname + "','" + cstatus + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(add, con); //dùng để thực hiện
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            FillGrid();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            FillGrid();
            //btn_Add.Enabled = true;
            //btn_Update.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string cid = txt_courseId.Text;
            string cname = txt_course_name.Text;
            string cstatus = txt_status.Text;
            string update = "Update Courses  SET CourseName= '" + cname + "',CStatus='" + cstatus + "' where CourseID= '" + cid + "' "; ;
            con.Open();
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
            FillGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("DO YOU WANT TO DELETE ?", "Confirmation", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                string cid = txt_courseId.Text;
                string cname = txt_course_name.Text;
                string cstatus = txt_status.Text;
                string delete = "Delete from Courses where CourseID='" + cid + "' ";
                con.Open();
                SqlCommand cmd1 = new SqlCommand(delete, con);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                con.Close();
                FillGrid();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_courseId.Clear();
            txt_course_name.Clear();
            txt_status.Clear();
        }

        private void dgv_list_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_list_course.Rows[e.RowIndex];
                txt_courseId.Text = row.Cells["CourseID"].Value.ToString();
                txt_course_name.Text = row.Cells["CourseName"].Value.ToString();
                txt_status.Text = row.Cells["CStatus"].Value.ToString();
                txt_courseId.Enabled = false;

            }
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Dispose();
        }

        private void btn_Update_Click_1(object sender, EventArgs e)
        {
            string cid = txt_courseId.Text;
            string cname = txt_course_name.Text;
            string cstatus = txt_status.Text;
            string update = "Update Courses  SET CourseName= '" + cname + "',CStatus='" + cstatus + "' where CourseID= '" + cid + "' "; ;
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
                string cid = txt_courseId.Text;
                string cname = txt_course_name.Text;
                string cstatus = txt_status.Text;
                string delete = "Delete from Courses where CourseID='" + cid + "' ";
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
            txt_courseId.Clear();
            txt_course_name.Clear();
            txt_status.Clear();
        }

        private void dgv_list_course_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_list_course.Rows[e.RowIndex];
                txt_courseId.Text = row.Cells["CourseID"].Value.ToString();
                txt_course_name.Text = row.Cells["CourseName"].Value.ToString();
                txt_status.Text = row.Cells["CStatus"].Value.ToString();
                txt_courseId.Enabled = false;

            }
        }
    }
}
