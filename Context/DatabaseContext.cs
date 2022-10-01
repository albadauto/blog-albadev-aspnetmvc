﻿using BlogDoDautin.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogDoDautin.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserModel> User { get; set; }
    }
}
