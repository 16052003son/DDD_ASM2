namespace AttendanceManagement
{
    partial class Attendance
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
            this.txt_courseId = new System.Windows.Forms.TextBox();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.dgv_list_attendance = new System.Windows.Forms.DataGridView();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_courseId
            // 
            this.txt_courseId.Location = new System.Drawing.Point(178, 186);
            this.txt_courseId.Name = "txt_courseId";
            this.txt_courseId.Size = new System.Drawing.Size(141, 22);
            this.txt_courseId.TabIndex = 35;
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(178, 130);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(141, 22);
            this.txt_userId.TabIndex = 34;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(524, 67);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 22);
            this.txt_date.TabIndex = 33;
            // 
            // dgv_list_attendance
            // 
            this.dgv_list_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_attendance.Location = new System.Drawing.Point(95, 329);
            this.dgv_list_attendance.Name = "dgv_list_attendance";
            this.dgv_list_attendance.RowHeadersWidth = 51;
            this.dgv_list_attendance.RowTemplate.Height = 24;
            this.dgv_list_attendance.Size = new System.Drawing.Size(802, 150);
            this.dgv_list_attendance.TabIndex = 32;
            this.dgv_list_attendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_attendance_CellContentClick_1);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(789, 24);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(162, 41);
            this.btn_home.TabIndex = 31;
            this.btn_home.Text = "Back To Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(700, 244);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 47);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(544, 244);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 47);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(374, 244);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 47);
            this.btn_update.TabIndex = 28;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(178, 244);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 47);
            this.btn_Add.TabIndex = 27;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(524, 144);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(200, 22);
            this.txt_status.TabIndex = 26;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(178, 61);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(141, 22);
            this.txt_Id.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "ADate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "CourseID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 503);
            this.Controls.Add(this.txt_courseId);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.dgv_list_attendance);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Attendance";
            this.Text = "AttendanceManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_courseId;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.DataGridView dgv_list_attendance;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}