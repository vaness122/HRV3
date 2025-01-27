﻿using HR.DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.Forms
{
    public partial class Login : Form
    {
        private readonly IUserRepo _userRepository;
        public Login(IUserRepo userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }


        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Login_Btn_Click(object sender, EventArgs e)
        {
            string Username = Username_Login.Text;
            string Password = Password_Login.Text;

            try
            {
                bool isAuthenticated = _userRepository.AuthenticUser(Username, Password);
                if (isAuthenticated)
                {
                    MessageBox.Show("Login is Successful");
                    this.Hide();
                    UserDashboard userDashboard = new UserDashboard(_userRepository, Username);
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_To_RegisterBtn_Click(object sender, EventArgs e)
        {
            {

                Register register = new Register(_userRepository);
                register.Show();

                // Optionally, hide the current Login form (if you don't want it to remain open)
                this.Hide();
            }
        }

        private void Password_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}