using AttendanceManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD_ASM2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Course_Click_1(object sender, EventArgs e)
        {
            Course course = new Course();
            this.Hide();
            course.ShowDialog();
            this.Dispose();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            this .Hide();
            attendance.ShowDialog();
            this.Dispose();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            User user = new User();
            this.Hide();
            user.ShowDialog();
            this.Dispose();
        }
    }
}
