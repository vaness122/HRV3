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
            Register_To_LoginBtn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Register_Btn = new Button();
            Password_Reg = new TextBox();
            Username_Reg = new TextBox();
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
            // Register_To_LoginBtn
            // 
            Register_To_LoginBtn.BackColor = SystemColors.ButtonFace;
            Register_To_LoginBtn.FlatStyle = FlatStyle.Popup;
            Register_To_LoginBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_To_LoginBtn.Location = new Point(98, 227);
            Register_To_LoginBtn.Name = "Register_To_LoginBtn";
            Register_To_LoginBtn.Size = new Size(75, 23);
            Register_To_LoginBtn.TabIndex = 7;
            Register_To_LoginBtn.Text = "Login";
            Register_To_LoginBtn.UseVisualStyleBackColor = false;
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
            // Register_Btn
            // 
            Register_Btn.BackColor = Color.Honeydew;
            Register_Btn.FlatStyle = FlatStyle.Popup;
            Register_Btn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_Btn.Location = new Point(197, 255);
            Register_Btn.Name = "Register_Btn";
            Register_Btn.Size = new Size(75, 23);
            Register_Btn.TabIndex = 13;
            Register_Btn.Text = "Register";
            Register_Btn.UseVisualStyleBackColor = false;
            // 
            // Password_Reg
            // 
            Password_Reg.Font = new Font("Segoe UI", 10F);
            Password_Reg.Location = new Point(60, 224);
            Password_Reg.Name = "Password_Reg";
            Password_Reg.Size = new Size(212, 25);
            Password_Reg.TabIndex = 12;
            // 
            // Username_Reg
            // 
            Username_Reg.Font = new Font("Segoe UI", 10F);
            Username_Reg.Location = new Point(60, 165);
            Username_Reg.Name = "Username_Reg";
            Username_Reg.Size = new Size(212, 25);
            Username_Reg.TabIndex = 11;
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
            panel2.Controls.Add(Register_To_LoginBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(319, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(311, 401);
            panel2.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 433);
            Controls.Add(panel1);
            Controls.Add(Register_Btn);
            Controls.Add(Password_Reg);
            Controls.Add(Username_Reg);
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
        private Button Register_To_LoginBtn;
        private Label label4;
        private PictureBox pictureBox1;
        private Button Register_Btn;
        private TextBox Password_Reg;
        private TextBox Username_Reg;
        private Label label3;
        private Label label2;
        private Panel panel2;
    }
}