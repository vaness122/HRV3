using HR.DAL.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public class UserRepo : IUserRepo
    {


        private readonly string connectionString =
         "Server=DESKTOP-AOJDK8M;Database=HRDB;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True";

        public void AddUser(string username, string password)
        {


            string query = "INSERT INTO HRIUsers (Username,Password) VALUES(@Username,@Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.ExecuteNonQuery();
                }

            }



        }

        public bool AuthenticUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string username)
        {
            throw new NotImplementedException();
        }

        public List<UserRepo> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(string oldUsername, string newUsername)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserPassword(string username, string newPassword)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepo.GetAllUser()
        {
            throw new NotImplementedException();
        }
    }
}
