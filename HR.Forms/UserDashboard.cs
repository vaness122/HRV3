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
using System.Xml;

namespace HR.Forms
{
    public partial class UserDashboard : Form
    {
        private readonly IUserRepo _userRepository;
        private readonly string _loggedInUsername;
        public UserDashboard(IUserRepo userRepository, string Username)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _loggedInUsername = Username;
        }


        private async void LoadUserData()
        {
            try
            {
                // Fetch the list of users
                var users = await _userRepository.GetAllUserAsyncs();

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
        private void Users_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {
                string username = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                try
                {
                    _userRepository.DeleteUser(username);
                    MessageBox.Show("User deleted successfully");
                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user" + ex.Message);
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
                    MessageBox.Show("User updated Successfully");

                    LoadUserData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user" + ex.Message);
                }




            }

        }

        private void Profile_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserProfile prof = new UserProfile(_userRepository, _loggedInUsername);
            prof.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void lbl_listofuser_Click(object sender, EventArgs e)
        {
            // Fetch the list of all users
            var users = await _userRepository.GetAllUserAsyncs();

            // Bind the list of users to your DataGridView (or any other control you're using)
            dataGridView1.DataSource = users;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Logout logic here
            MessageBox.Show("You have logged out successfully!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the current form
            this.Close();

            // Optionally show the login form (make sure it's in the correct namespace)
            Login login = new Login(_userRepository);
            login.Show();
        }

        private void Name_Click(object sender, EventArgs e)
{
          Name.Text = _loggedInUsername; 
}

    }
}


