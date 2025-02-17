namespace HR.Forms
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel1 = new Panel();
            lblclose = new Label();
            Name = new Label();
            Profile_Btn = new Button();
            lbl_listofuser = new Button();
            btn_logout = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Users_Edit = new Button();
            Users_Delete = new Button();
            updateUsernameTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(lblclose);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 30);
            panel1.TabIndex = 2;
            // 
            // lblclose
            // 
            lblclose.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclose.ForeColor = SystemColors.ButtonFace;
            lblclose.Location = new Point(544, 0);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(29, 29);
            lblclose.TabIndex = 20;
            lblclose.Text = "X";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.Location = new Point(69, 150);
            Name.Name = "Name";
            Name.Size = new Size(61, 14);
            Name.TabIndex = 3;
            Name.Text = "Username";
            // 
            // Profile_Btn
            // 
            Profile_Btn.Location = new Point(43, 206);
            Profile_Btn.Name = "Profile_Btn";
            Profile_Btn.Size = new Size(100, 23);
            Profile_Btn.TabIndex = 4;
            Profile_Btn.Text = "Profile";
            Profile_Btn.UseVisualStyleBackColor = true;
            // 
            // lbl_listofuser
            // 
            lbl_listofuser.Location = new Point(43, 226);
            lbl_listofuser.Name = "lbl_listofuser";
            lbl_listofuser.Size = new Size(100, 23);
            lbl_listofuser.TabIndex = 5;
            lbl_listofuser.Text = "List of User";
            lbl_listofuser.UseVisualStyleBackColor = true;
            lbl_listofuser.Click += lbl_listofuser_Click_1;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(43, 246);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(100, 23);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(Name);
            panel2.Location = new Point(-1, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 407);
            panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(240, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(302, 259);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Users_Edit
            // 
            Users_Edit.Location = new Point(386, 346);
            Users_Edit.Name = "Users_Edit";
            Users_Edit.Size = new Size(75, 23);
            Users_Edit.TabIndex = 10;
            Users_Edit.Text = "Edit";
            Users_Edit.UseVisualStyleBackColor = true;
            Users_Edit.Click += Users_Edit_Click_1;
            // 
            // Users_Delete
            // 
            Users_Delete.Location = new Point(467, 346);
            Users_Delete.Name = "Users_Delete";
            Users_Delete.Size = new Size(75, 23);
            Users_Delete.TabIndex = 11;
            Users_Delete.Text = "Delete";
            Users_Delete.UseVisualStyleBackColor = true;
            Users_Delete.Click += Users_Delete_Click;
            // 
            // updateUsernameTextBox
            // 
            updateUsernameTextBox.Location = new Point(240, 347);
            updateUsernameTextBox.Name = "updateUsernameTextBox";
            updateUsernameTextBox.Size = new Size(140, 23);
            updateUsernameTextBox.TabIndex = 12;

         

            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(572, 433);
            Controls.Add(updateUsernameTextBox);
            Controls.Add(Users_Delete);
            Controls.Add(Users_Edit);
            Controls.Add(dataGridView1);
            Controls.Add(btn_logout);
            Controls.Add(lbl_listofuser);
            Controls.Add(Profile_Btn);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;    
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Name;
        private Button Profile_Btn;
        private Button lbl_listofuser;
        private Button btn_logout;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button Users_Edit;
        private Button Users_Delete;
        private TextBox updateUsernameTextBox;
        private Label lblclose;
      
    }
}
