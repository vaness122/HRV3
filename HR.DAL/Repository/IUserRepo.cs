using HR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public interface IUserRepo
    {
        Task AddUser(string username, string password);
        Task UpdateUser(string oldUsername, string newUsername);
        Task UpdateUserPassword(string username, string newPassword);
        Task DeleteUser(string username);
        bool AuthenticUser(string username, string password);
<<<<<<< HEAD
        List<User> GetAllUser();
=======

>>>>>>> 1c6e5bbe752d41f163482e91f85cf3605bb631b3
        Task<List<User>> GetAllUserAsyncs();
    }
}
