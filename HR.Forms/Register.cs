using HR.DAL.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
<<<<<<< HEAD
=======

>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
namespace HR.Forms
{
    public partial class Register : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly IUserRepo _userRepository;
      
       
=======
        private static readonly HttpClient client = new HttpClient();
>>>>>>> fd940f40ba5943c2d01a0a7a7afe304921f1616c
=======
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "https://localhost:7293/api/";
        private readonly IUserRepo _userRepository;
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc

        public Register()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

<<<<<<< HEAD
        

        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
=======
            _userRepository = userRepository;
            _httpClient = new HttpClient { BaseAddress = new Uri(_apiBaseUrl) }; // Simplified new expression
        }

        // Button Click for Register
        private async void Register_Btn_Click(object sender, EventArgs e)
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
        {
            string username = Username_Register.Text;
            string password = Password_Register.Text;

<<<<<<< HEAD
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private  void Register_Btn_Click(object sender, EventArgs e)
=======
        private async void Register_Btn_Click(object sender, EventArgs e)
>>>>>>> fd940f40ba5943c2d01a0a7a7afe304921f1616c
        {
            string Username = Username_Register.Text;
            string Password = Password_Register.Text;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
=======
            // Validate input fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
            {
                MessageBox.Show("Username or Password cannot be empty.");
                return;
            }

            var user = new User
            {
                Username = Username,
                Password = Password
            };

            try
            {
<<<<<<< HEAD

                string json = JsonConvert.SerializeObject(user);


                var content = new StringContent(json, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/user/register", content);


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Registered Successfully");
=======
                // Create a user object to send to the API
                var user = new { Username = username, Password = password };

                // Serialize the user object to JSON
                var jsonContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                // Send a POST request to the register API endpoint
                var response = await _httpClient.PostAsync("user/register", jsonContent);

                // Check if the registration was successful
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Registered Successfully");
                    // Clear the input fields
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
                    Username_Register.Clear();
                    Password_Register.Clear();
                }
                else
                {
<<<<<<< HEAD
                    MessageBox.Show("Error: " + response.ReasonPhrase);
=======
                    // Show error if registration failed
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {errorMessage}");
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
                }
            }
            catch (Exception ex)
            {
                // Catch any unexpected errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

<<<<<<< HEAD
        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

=======
        // Button Click to navigate back to Login form
        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login(_userRepository); // Pass the required parameter
            log.Show();
        }

        // Close the Register form
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
