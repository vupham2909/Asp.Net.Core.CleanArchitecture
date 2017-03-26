using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Domain.Users;
using Common.DatabaseService;

namespace Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.FirstName).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
        }
    }
}
