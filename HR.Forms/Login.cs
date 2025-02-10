using HR.DAL.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HR.Forms
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Btn_Click(object sender, EventArgs e)
        {
            string Username = Username_Login.Text;
            string Password = Password_Login.Text;

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


                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/user/authenticate", content);


                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Login is Successful");



                    this.Hide();
                    UserDashboard userDashboard = new UserDashboard();
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
            this.Close();
        }

        private void Login_To_RegisterBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();


            this.Hide();
        }

        private void Password_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
