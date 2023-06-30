using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio14C.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio14C.DataContext
{
    public class AppDbContext: DbContext
    {
        string DbPath = string.Empty;

        public DbSet<Course> Courses { get; set; }

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
