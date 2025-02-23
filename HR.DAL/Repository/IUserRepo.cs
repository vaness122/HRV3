using HR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public interface IUserRepo
    {
        Task AddUser(string username, string password);
        Task UpdateUser(string oldUsername, string newUsername, int id);
        Task UpdateUserPassword(string username, string newPassword, int id);
        Task DeleteUser( int id);
        bool AuthenticUser(string username, string password);

        List<User> GetAllUser();
        Task<User> GetUserByIdAsync(int id);

        Task<List<User>> GetAllUserAsyncs();
       
    }
}
