using HR.DAL.Models;
using HR.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;
        private static readonly HttpClient client = new HttpClient(); // HttpClient for API requests

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }

        // Example of calling API to add user remotely
        public async Task AddUser(string username, string password)
        {
            try
            {
                // Check if user exists in the database before adding
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (existingUser != null)
                {
                    throw new Exception("Username already exists.");
                }

                // Create a new user and add to the database
                var user = new User { Username = username, Password = password };
                _context.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding user: " + ex.Message);
            }
        }


        // Authenticate user (e.g., check credentials)
        public bool AuthenticUser(string username, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                return user != null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error authenticating user: " + ex.Message);
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id ==  id);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while deleting user: " + ex.Message);
            }
        }


        public async Task UpdateUser(string oldUsername, string newUsername, int id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
                if (user != null)
                {
                    user.Username = newUsername;
                    _context.Users.Update(user);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating username: " + ex.Message);
            }
        }

   
        public async Task UpdateUserPassword(string username, string newPassword, int id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
                if (user != null)
                {
                    user.Password = newPassword;
                    _context.Users.Update(user);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating password: " + ex.Message);
            }
        }

        // Retrieve all users from the database (without API call)
        public async Task<List<User>> GetAllUserAsyncs()
        {
            return await _context.Users.ToListAsync();
        }

        // Placeholder for any other future methods (get all users, etc.)
        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }


        public async Task<User> GetUserByIdAsync(int id)
        {
            try
            {
                return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching user by ID: " + ex.Message);
            }
        }

        public Task GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

      
    }
}
