using HR.DAL.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using HR.DAL.Repository;

namespace HR.Forms
{
    public partial class Register : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "https://localhost:7293/api/";
        private readonly IUserRepo _userRepository;

        public Register(IUserRepo userRepository) // Injecting the user repository
        {
            InitializeComponent();
            _userRepository = userRepository;
            _httpClient = new HttpClient { BaseAddress = new Uri(_apiBaseUrl) }; // Simplified new expression
        }

        // Button Click for Register
        private async void Register_Btn_Click(object sender, EventArgs e)
        {
            string username = Username_Register.Text;
            string password = Password_Register.Text;

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

                string json = JsonConvert.SerializeObject(user);


                var content = new StringContent(json, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await Client.PostAsync("http://localhost:7293/api/user/register", content);


                // Check if the registration was successful
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Registered Successfully");
                    Username_Register.Clear();
                    Password_Register.Clear();
                }
                else
                {
                    // Show error if registration failed
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Button Click to navigate back to Login form
        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login(_userRepository); // Pass the required parameter
            log.Show();
        }

        // Close the Register form
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
