namespace HR.Forms
{
    partial class Register
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
            lbl1close = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Register_ToLoginBtn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Register_Btn = new Button();
            label2 = new Label();
            label3 = new Label();
            Username_Register = new TextBox();
            Password_Register = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl1close
            // 
            lbl1close.AutoSize = true;
            lbl1close.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1close.ForeColor = SystemColors.ButtonFace;
            lbl1close.Location = new Point(566, 0);
            lbl1close.Name = "lbl1close";
            lbl1close.Size = new Size(30, 32);
            lbl1close.TabIndex = 0;
            lbl1close.Text = "X";
            lbl1close.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(lbl1close);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 35);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(Register_ToLoginBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-10, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 401);
            panel2.TabIndex = 1;
            // 
            // Register_ToLoginBtn
            // 
            Register_ToLoginBtn.BackColor = SystemColors.ButtonFace;
            Register_ToLoginBtn.FlatStyle = FlatStyle.Popup;
            Register_ToLoginBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_ToLoginBtn.Location = new Point(131, 241);
            Register_ToLoginBtn.Name = "Register_ToLoginBtn";
            Register_ToLoginBtn.Size = new Size(75, 23);
            Register_ToLoginBtn.TabIndex = 6;
            Register_ToLoginBtn.Text = "Login";
            Register_ToLoginBtn.UseVisualStyleBackColor = false;
           
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 215);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 8;
            label4.Text = "New User?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ri;
            pictureBox1.Location = new Point(122, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Register_Btn
            // 
            Register_Btn.BackColor = Color.Honeydew;
            Register_Btn.FlatStyle = FlatStyle.Popup;
            Register_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_Btn.Location = new Point(480, 275);
            Register_Btn.Name = "Register_Btn";
            Register_Btn.Size = new Size(75, 23);
            Register_Btn.TabIndex = 7;
            Register_Btn.Text = "Register";
            Register_Btn.UseVisualStyleBackColor = false;
            Register_Btn.Click += Register_Btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label2.Location = new Point(343, 166);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            label3.Location = new Point(343, 225);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // Username_Register
            // 
            Username_Register.Font = new Font("Segoe UI", 10F);
            Username_Register.Location = new Point(343, 185);
            Username_Register.Name = "Username_Register";
            Username_Register.Size = new Size(212, 25);
            Username_Register.TabIndex = 4;
            // 
            // Password_Register
            // 
            Password_Register.Font = new Font("Segoe UI", 10F);
            Password_Register.Location = new Point(343, 244);
            Password_Register.Name = "Password_Register";
            Password_Register.PasswordChar = '*';
            Password_Register.Size = new Size(212, 25);
            Password_Register.TabIndex = 5;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(595, 433);
            Controls.Add(Password_Register);
            Controls.Add(Register_Btn);
            Controls.Add(Username_Register);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1close;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox Username_Register;
        private TextBox Password_Register;
        private Button Register_ToLoginBtn;

        private Button Register_Btn;
        private Label label4;
        private PictureBox pictureBox1;
    }
}