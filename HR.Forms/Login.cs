<<<<<<< HEAD
﻿using HR.DAL.Models;
using System;
=======
﻿using System;
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using HR.DAL.Repository;
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
using Newtonsoft.Json;

namespace HR.Forms
{
    public partial class Login : Form
    {
<<<<<<< HEAD
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

=======
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

        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
        }

>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
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

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
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


                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/user/authenticate", content);

=======
                var user = new { Username = username, Password = password };

                // Serialize the user object to JSON
                var jsonContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                // Send a POST request to the authenticate API endpoint
                var response = await _httpClient.PostAsync("user/authenticate", jsonContent);
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Login is Successful");



                    this.Hide();
<<<<<<< HEAD
                    UserDashboard userDashboard = new UserDashboard();
=======

                    // Pass the userRepository and username to the UserDashboard constructor
                    UserDashboard userDashboard = new UserDashboard(_userRepository, username);
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
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
<<<<<<< HEAD
        }

        private void X_Btn_Click(object sender, EventArgs e)
        {
            Close();
=======
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_To_RegisterBtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Register register = new Register();
            register.Show();


            this.Hide();
=======
            this.Hide();
            Register register = new Register(_userRepository);
            register.Show();
>>>>>>> 03bf1a7a85430de312080e294821ce0d02e60dcc
        }

        // Password TextChanged event handler (if needed)
        private void Password_Login_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here if you want to handle text changes for password
        }
    }
}
