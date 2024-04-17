namespace AttendanceManagement
{
    partial class Course
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
            this.dgv_list_course = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.txt_courseId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_course)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_list_course
            // 
            this.dgv_list_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_course.Location = new System.Drawing.Point(53, 309);
            this.dgv_list_course.Name = "dgv_list_course";
            this.dgv_list_course.RowHeadersWidth = 51;
            this.dgv_list_course.RowTemplate.Height = 24;
            this.dgv_list_course.Size = new System.Drawing.Size(768, 150);
            this.dgv_list_course.TabIndex = 23;
            this.dgv_list_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_course_CellContentClick_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(839, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 39);
            this.button5.TabIndex = 22;
            this.button5.Text = "Back To Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(737, 188);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 39);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(542, 188);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 39);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(737, 88);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 39);
            this.btn_Update.TabIndex = 19;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(542, 85);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 39);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(177, 220);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(177, 22);
            this.txt_status.TabIndex = 17;
            // 
            // txt_course_name
            // 
            this.txt_course_name.Location = new System.Drawing.Point(177, 152);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(177, 22);
            this.txt_course_name.TabIndex = 16;
            // 
            // txt_courseId
            // 
            this.txt_courseId.Location = new System.Drawing.Point(177, 71);
            this.txt_courseId.Name = "txt_courseId";
            this.txt_courseId.Size = new System.Drawing.Size(177, 22);
            this.txt_courseId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "CourseName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "CourseID";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 520);
            this.Controls.Add(this.dgv_list_course);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_course_name);
            this.Controls.Add(this.txt_courseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Course";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_list_course;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_course_name;
        private System.Windows.Forms.TextBox txt_courseId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}