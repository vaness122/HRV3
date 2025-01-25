using HR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public interface IUserRepo
    {

        void AddUser(string username, string password);
        void UpdateUser(string oldUsername, string newUsername);
        void UpdateUserPassword(string username, string newPassword);
        void DeleteUser(string username);
        bool AuthenticUser(string username, string password);
        List<User> GetAllUser();


    }
}
