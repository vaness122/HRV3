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


        private void LoadUserData()
        {
            try
            {

                var Users = _userRepository.GetAllUser();
                dataGridView1.DataSource = Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Users:" + ex.Message);
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

        
    }
}

