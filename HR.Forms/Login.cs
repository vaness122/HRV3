using HR.DAL.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using HR.DAL.Repository;
using Newtonsoft.Json;

namespace HR.Forms
{
    public partial class Login : Form
    {
        private readonly IUserRepo _userRepository; // Add reference to IUserRepo
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "https://localhost:7293/api/";

        public Login(IUserRepo userRepository) // Inject IUserRepo
        {
            InitializeComponent();
            _userRepository = userRepository;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_apiBaseUrl);
        }

        private async void Login_Btn_Click(object sender, EventArgs e)
        {
            string username = Username_Login.Text;
            string password = Password_Login.Text;

            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or Password cannot be empty.");
                return;
            }

            var user = new { Username = username, Password = password };

            try
            {
                // Serialize the user object to JSON
                var jsonContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                // Send a POST request to the authenticate API endpoint
                var response = await _httpClient.PostAsync("user/authenticate", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Login is Successful");

                    this.Hide();
                    // Pass the userRepository and username to the UserDashboard constructor
                    UserDashboard userDashboard = new UserDashboard(_userRepository, username);
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_To_RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(_userRepository);
            register.Show();
        }

        // Password TextChanged event handler (if needed)
        private void Password_Login_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here if you want to handle text changes for password
        }
    }
}
