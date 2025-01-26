namespace HR.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            Login_Btn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Login_To_RegisterBtn = new Button();
            Password_Login = new TextBox();
            Username_Login = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 35);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(566, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 32);
            label1.TabIndex = 0;
            label1.Text = "X";
            // 
            // Login_Btn
            // 
            Login_Btn.BackColor = Color.Honeydew;
            Login_Btn.FlatStyle = FlatStyle.Popup;
            Login_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Btn.Location = new Point(197, 255);
            Login_Btn.Name = "Login_Btn";
            Login_Btn.Size = new Size(75, 23);
            Login_Btn.TabIndex = 7;
            Login_Btn.Text = "Login";
            Login_Btn.UseVisualStyleBackColor = false;
            Login_Btn.Click += Login_Btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 210);
            label4.Name = "label4";
            label4.Size = new Size(142, 14);
            label4.TabIndex = 8;
            label4.Text = "Already have an account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login_To_RegisterBtn
            // 
            Login_To_RegisterBtn.BackColor = SystemColors.ButtonFace;
            Login_To_RegisterBtn.FlatStyle = FlatStyle.Popup;
            Login_To_RegisterBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_To_RegisterBtn.Location = new Point(109, 227);
            Login_To_RegisterBtn.Name = "Login_To_RegisterBtn";
            Login_To_RegisterBtn.Size = new Size(75, 23);
            Login_To_RegisterBtn.TabIndex = 13;
            Login_To_RegisterBtn.Text = "Register";
            Login_To_RegisterBtn.UseVisualStyleBackColor = false;
           
            // 
            // Password_Login
            // 
            Password_Login.Font = new Font("Segoe UI", 10F);
            Password_Login.Location = new Point(60, 224);
            Password_Login.Name = "Password_Login";
            Password_Login.Size = new Size(212, 25);
            Password_Login.TabIndex = 12;
            // 
            // Username_Login
            // 
            Username_Login.Font = new Font("Segoe UI", 10F);
            Username_Login.Location = new Point(60, 165);
            Username_Login.Name = "Username_Login";
            Username_Login.Size = new Size(212, 25);
            Username_Login.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label3.Location = new Point(60, 205);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 10;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.Location = new Point(60, 146);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 9;
            label2.Text = "Username :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(Login_To_RegisterBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(319, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 407);
            panel2.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 433);
            Controls.Add(Login_Btn);
            Controls.Add(panel1);
            Controls.Add(Password_Login);
            Controls.Add(Username_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button Login_Btn;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Login_To_RegisterBtn;
        private TextBox Password_Login;
        private TextBox Username_Login;
        private Label label3;
        private Label label2;
        private Panel panel2;
    }
}