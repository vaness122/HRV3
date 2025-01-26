﻿using HR.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace HR.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
