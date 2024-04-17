namespace DDD_ASM2
{
    partial class SearchStudent
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
            this.btn_home = new System.Windows.Forms.Button();
            this.dgv_list_search = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(741, 43);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(141, 41);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Back To Login";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click_1);
            // 
            // dgv_list_search
            // 
            this.dgv_list_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_search.Location = new System.Drawing.Point(179, 147);
            this.dgv_list_search.Name = "dgv_list_search";
            this.dgv_list_search.RowHeadersWidth = 51;
            this.dgv_list_search.RowTemplate.Height = 24;
            this.dgv_list_search.Size = new System.Drawing.Size(609, 260);
            this.dgv_list_search.TabIndex = 6;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(319, 79);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(217, 22);
            this.txt_search.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.dgv_list_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button1);
            this.Name = "SearchStudent";
            this.Text = "SearchStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.DataGridView dgv_list_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
    }
}