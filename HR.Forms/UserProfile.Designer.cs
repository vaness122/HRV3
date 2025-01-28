namespace HR.Forms
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            logout_btn = new Button();
            List_UsersBtn = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            EditUser_Btn = new Button();
            updatePassword_Btn = new TextBox();
            updateUsernameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Location = new Point(-7, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 30);
            panel1.TabIndex = 9;
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
            // logout_btn
            // 
            logout_btn.Location = new Point(37, 245);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(100, 23);
            logout_btn.TabIndex = 12;
            logout_btn.Text = "Logout";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // List_UsersBtn
            // 
            List_UsersBtn.Location = new Point(37, 225);
            List_UsersBtn.Name = "List_UsersBtn";
            List_UsersBtn.Size = new Size(100, 23);
            List_UsersBtn.TabIndex = 11;
            List_UsersBtn.Text = "List of User";
            List_UsersBtn.UseVisualStyleBackColor = true;
            List_UsersBtn.Click += List_UsersBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 205);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 10;
            button1.Text = "Profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-7, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 407);
            panel2.TabIndex = 13;
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
            // EditUser_Btn
            // 
            EditUser_Btn.BackColor = Color.Honeydew;
            EditUser_Btn.FlatStyle = FlatStyle.Popup;
            EditUser_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditUser_Btn.Location = new Point(419, 262);
            EditUser_Btn.Name = "EditUser_Btn";
            EditUser_Btn.Size = new Size(75, 23);
            EditUser_Btn.TabIndex = 18;
            EditUser_Btn.Text = "Edit";
            EditUser_Btn.UseVisualStyleBackColor = false;
            EditUser_Btn.Click += EditUser_Btn_Click;
            // 
            // updatePassword_Btn
            // 
            updatePassword_Btn.Font = new Font("Segoe UI", 10F);
            updatePassword_Btn.Location = new Point(282, 231);
            updatePassword_Btn.Name = "updatePassword_Btn";
            updatePassword_Btn.Size = new Size(212, 25);
            updatePassword_Btn.TabIndex = 17;
            // 
            // updateUsernameTextBox
            // 
            updateUsernameTextBox.Font = new Font("Segoe UI", 10F);
            updateUsernameTextBox.ImeMode = ImeMode.NoControl;
            updateUsernameTextBox.Location = new Point(282, 172);
            updateUsernameTextBox.Name = "updateUsernameTextBox";
            updateUsernameTextBox.Size = new Size(212, 25);
            updateUsernameTextBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label3.Location = new Point(282, 212);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 15;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.Location = new Point(282, 153);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 14;
            label2.Text = "Username :";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(538, 433);
            Controls.Add(EditUser_Btn);
            Controls.Add(updatePassword_Btn);
            Controls.Add(updateUsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(logout_btn);
            Controls.Add(List_UsersBtn);
            Controls.Add(button1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProfile";
            Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button logout_btn;
        private Button List_UsersBtn;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Button EditUser_Btn;
        private TextBox updatePassword_Btn;
        private TextBox updateUsernameTextBox;
        private Label label3;
        private Label label2;
    }
}