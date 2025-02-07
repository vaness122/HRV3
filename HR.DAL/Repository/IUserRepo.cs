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

        List<User> GetAllUser();



        Task<List<User>> GetAllUserAsyncs();
    }
}
