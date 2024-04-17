namespace DDD_ASM2
{
    partial class User
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
            this.txt_dob = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.dgv_list_user = new System.Windows.Forms.DataGridView();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_roles = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(109, 218);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(166, 22);
            this.txt_dob.TabIndex = 40;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(902, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(131, 63);
            this.btn_home.TabIndex = 39;
            this.btn_home.Text = "Back To Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // dgv_list_user
            // 
            this.dgv_list_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_user.Location = new System.Drawing.Point(80, 278);
            this.dgv_list_user.Name = "dgv_list_user";
            this.dgv_list_user.RowHeadersWidth = 51;
            this.dgv_list_user.RowTemplate.Height = 24;
            this.dgv_list_user.Size = new System.Drawing.Size(924, 215);
            this.dgv_list_user.TabIndex = 38;
            this.dgv_list_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_user_CellContentClick_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(787, 128);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 63);
            this.btn_clear.TabIndex = 37;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(645, 131);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 63);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(787, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 63);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(418, 163);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(166, 22);
            this.txt_phone.TabIndex = 33;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(418, 104);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(166, 22);
            this.txt_email.TabIndex = 32;
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(418, 37);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(166, 22);
            this.txt_class.TabIndex = 31;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(109, 160);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(166, 22);
            this.txt_pass.TabIndex = 30;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(109, 101);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(166, 22);
            this.txt_username.TabIndex = 29;
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(109, 43);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(166, 22);
            this.txt_userId.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "DoB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "UserID";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(645, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 51);
            this.btn_add.TabIndex = 41;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "RolesId";
            // 
            // txt_roles
            // 
            this.txt_roles.Location = new System.Drawing.Point(418, 218);
            this.txt_roles.Name = "txt_roles";
            this.txt_roles.Size = new System.Drawing.Size(166, 22);
            this.txt_roles.TabIndex = 43;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 566);
            this.Controls.Add(this.txt_roles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.dgv_list_user);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dob;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.DataGridView dgv_list_user;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_roles;
    }
}