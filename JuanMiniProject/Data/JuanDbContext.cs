﻿using JuanMiniProject.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanMiniProject.Data
{
    public class JuanDbContext : DbContext
    {
        public DbSet<Setting> Settings { get; set; }
        public JuanDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
       
