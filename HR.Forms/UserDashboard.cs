﻿using HR.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.Forms
{
    public partial class UserDashboard : Form
    {
        private readonly IUserRepo _userRepository;
        private readonly string _loggedInUsername;

        // Modify this constructor to accept both IUserRepo and the logged-in username
        public UserDashboard(IUserRepo userRepository, string loggedInUsername)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _loggedInUsername = loggedInUsername;

            // Use _loggedInUsername for user-related UI or data
            Name.Text = _loggedInUsername;
        }

        private static readonly HttpClient client = new HttpClient();

        private async void LoadUserData()
        {
            try
            {
                var users = await _userRepository.GetAllUserAsyncs();
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private async Task Users_Delete_ClickAsync(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string username = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                try
                {
                    await _userRepository.DeleteUser(username);
                    MessageBox.Show("User deleted successfully");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete");
            }
        }

        private void Users_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string oldUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                string newUsername = updateUsernameTextBox.Text;
                try
                {
                    _userRepository.UpdateUser(oldUsername, newUsername);
                    MessageBox.Show("User updated successfully");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }

        private void Profile_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile prof = new UserProfile(_userRepository, _loggedInUsername);
            prof.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void lbl_listofuser_Click(object sender, EventArgs e)
        {
            var users = await _userRepository.GetAllUserAsyncs();
            dataGridView1.DataSource = users;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have logged out successfully!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            // Assuming Login form requires IUserRepo (e.g. dependency injection)
            Login login = new Login(_userRepository);
            login.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            Name.Text = _loggedInUsername;
        }
    }
}
