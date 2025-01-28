﻿using HR.DAL.Models;
using HR.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.DAL.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _context;

        public UserRepo(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUserAsyncs()
        {
            return await _context.Users.ToListAsync();  
        }

  

        public async Task AddUser(string username, string password)
        {
            try
            {
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
                if (existingUser != null)
                {
                    throw new Exception("Username already exists.");
                }

                var user = new User { Username = username, Password = password };
                _context.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while adding user: " + ex.Message);
            }
        }

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

        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUserAsyncs()
        {
            throw new NotImplementedException();
        }

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

        public Task GetAllUserAsync()
        {
            throw new NotImplementedException();
        }
    }
}
