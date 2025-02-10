using HR.DAL.Repository;
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
    public partial class UserProfile : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly IUserRepo _userRepository;
        private readonly string _loggedInUsername;


        public UserProfile(IUserRepo userRepository, string Username)
        {
            InitializeComponent();
            
        }

        private async void EditUser_Btn_Click(object sender, EventArgs e)
        {
            string newUsername = updateUsernameTextBox.Text;
            string newPassword = updatePassword_Btn.Text;

            // Check if both fields are filled
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please fill both fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update username if it's different

            if (_loggedInUsername != newUsername)
            {
                try
                {
                    await _userRepository.UpdateUser(_loggedInUsername, newUsername);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to update username. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            _userRepository.UpdateUserPassword(newUsername, newPassword);

            // Update password
            try
            {
                await _userRepository.UpdateUserPassword(newUsername, newPassword);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // If both updates are successful, show a success message
            MessageBox.Show("Your changes have been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally update the logged-in username if the username was changed

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            Name_Txt.Text = _loggedInUsername;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You have logged out successfully!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Login login = new Login();
            login.Show();
        }


        private void List_UsersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dashboard = new UserDashboard();
            dashboard.Show();
        }


        private void logout_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
