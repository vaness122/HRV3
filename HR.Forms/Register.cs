using HR.DAL.Models;
using HR.DAL.Repository;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HR.Forms
{
    public partial class Register : Form
    {
        private static readonly HttpClient client = new HttpClient();

        // Constructor
        public Register()
        {
            InitializeComponent();
        }

        // Registration Button Click Handler
        private async void Register_Btn_Click(object sender, EventArgs e)
        {
            string Username = Username_Register.Text;
            string Password = Password_Register.Text;

            // Validate input fields
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
                string json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send registration request
                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/user/register", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Registered Successfully");
                    Username_Register.Clear();
                    Password_Register.Clear();
                }
                else
                {
                    MessageBox.Show("Error: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Navigate to Login Form
        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        // Close the form when label is clicked
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
