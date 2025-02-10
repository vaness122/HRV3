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
                // Check if user exists in the database before calling API
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (existingUser != null)
                {
                    throw new Exception("Username already exists.");
                }

                // Call external API to register user
                var user = new User { Username = username, Password = password };
                string json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Replace with your API URL for registration
                HttpResponseMessage response = await client.PostAsync("http://localhost:5000/api/user/register", content);

                if (response.IsSuccessStatusCode)
                {
                    // If successful, save to database
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("Error while registering user with API: " + response.ReasonPhrase);
                }
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

        // Delete user locally (also can make API call if needed)
        public async Task DeleteUser(string username)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
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

        // Update user locally (can also call API for external update if needed)
        public async Task UpdateUser(string oldUsername, string newUsername)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == oldUsername);
                if (user != null)
                {
                    user.Username = newUsername;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating username: " + ex.Message);
            }
        }

        // Update password locally (can be sent to API if necessary)
        public async Task UpdateUserPassword(string username, string newPassword)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (user != null)
                {
                    user.Password = newPassword;
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

        // Placeholder for API user retrieval (if needed in the future)
        public Task GetAllUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
