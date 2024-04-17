namespace DDD_ASM2
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Course = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_attendance = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Course
            // 
            this.btn_Course.Location = new System.Drawing.Point(584, 87);
            this.btn_Course.Name = "btn_Course";
            this.btn_Course.Size = new System.Drawing.Size(193, 98);
            this.btn_Course.TabIndex = 5;
            this.btn_Course.Text = "Course";
            this.btn_Course.UseVisualStyleBackColor = true;
            this.btn_Course.Click += new System.EventHandler(this.btn_Course_Click_1);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(895, 326);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 50);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_attendance
            // 
            this.btn_attendance.Location = new System.Drawing.Point(126, 105);
            this.btn_attendance.Name = "btn_attendance";
            this.btn_attendance.Size = new System.Drawing.Size(193, 98);
            this.btn_attendance.TabIndex = 8;
            this.btn_attendance.Text = "Attendance";
            this.btn_attendance.UseVisualStyleBackColor = true;
            this.btn_attendance.Click += new System.EventHandler(this.btn_attendance_Click);
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(336, 261);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(193, 98);
            this.btn_user.TabIndex = 9;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 450);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_attendance);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Course);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Course;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_attendance;
        private System.Windows.Forms.Button btn_user;
    }
}