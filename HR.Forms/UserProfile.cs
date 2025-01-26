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

        private readonly IUserRepo _userRepository;
        private readonly string _loggedInUsername;


        public UserProfile(IUserRepo userRepository, string Username)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _loggedInUsername = Username;
        }

        private void EditUser_Btn_Click(object sender, EventArgs e)
        {
            string newUsername = updateUsernameTextBox.Text;
            string newPassword = updatePassword_Btn.Text;

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("please fill both fields");
                return;
            }

            if(_loggedInUsername != newUsername)
            {
                _userRepository.UpdateUser(_loggedInUsername, newUsername);
            }

            _userRepository.UpdateUserPassword(newUsername,newPassword);


        }
    }
}
