using HR.DAL.Repository;
using System;
using System.Windows.Forms;

namespace HR.Forms
{
    public partial class Register : Form
    {
        private readonly IUserRepo _userRepository;

        public Register(IUserRepo userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }



        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login(_userRepository);
            log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  void Register_Btn_Click(object sender, EventArgs e)
        {
            string Username = Username_Register.Text;
            string Password = Password_Register.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Username or Password cannot be empty.");
                return;
            }

            try
            {
                Console.WriteLine($"Attempting to register user: {Username}");

                
                 _userRepository.AddUser(Username, Password);
                MessageBox.Show("User Registered Successfully");

                
                Username_Register.Clear();
                Password_Register.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
