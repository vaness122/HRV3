using HR.DAL.Models;
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
<<<<<<< HEAD
        private readonly IUserRepo _userRepository;
      
       
=======
        private static readonly HttpClient client = new HttpClient();
>>>>>>> fd940f40ba5943c2d01a0a7a7afe304921f1616c

        public Register()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        

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
=======
        private async void Register_Btn_Click(object sender, EventArgs e)
>>>>>>> fd940f40ba5943c2d01a0a7a7afe304921f1616c
        {
            string Username = Username_Register.Text;
            string Password = Password_Register.Text;

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

        private void Register_ToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
