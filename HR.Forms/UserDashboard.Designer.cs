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
            label1 = new Label();
            Profile_Btn = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Users_Edit = new Button();
            Users_Delete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 30);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 150);
            label1.Name = "label1";
            label1.Size = new Size(61, 14);
            label1.TabIndex = 3;
            label1.Text = "Username";
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
            // button2
            // 
            button2.Location = new Point(43, 226);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "List of User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(43, 246);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
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
            panel2.Controls.Add(label1);
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
            // 
            // Users_Edit
            // 
            Users_Edit.Location = new Point(386, 346);
            Users_Edit.Name = "Users_Edit";
            Users_Edit.Size = new Size(75, 23);
            Users_Edit.TabIndex = 10;
            Users_Edit.Text = "Edit";
            Users_Edit.UseVisualStyleBackColor = true;
            // 
            // Users_Delete
            // 
            Users_Delete.Location = new Point(467, 346);
            Users_Delete.Name = "Users_Delete";
            Users_Delete.Size = new Size(75, 23);
            Users_Delete.TabIndex = 11;
            Users_Delete.Text = "Delete";
            Users_Delete.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(595, 433);
            Controls.Add(Users_Delete);
            Controls.Add(Users_Edit);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Profile_Btn);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Profile_Btn;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button Users_Edit;
        private Button Users_Delete;
    }
}