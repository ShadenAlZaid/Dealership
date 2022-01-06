using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dealership.BlazorApp.Data
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureUsers(modelBuilder);
            ConfigureRoles(modelBuilder);
            ConfigureUserRoles(modelBuilder);

        }
        private static void ConfigureUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>()
                .HasData(
                    new List<IdentityUser<Guid>>() {
                        new IdentityUser<Guid>("aff3b9d0-2e80-4582-923b-d238e5383b70")
                    });
        }

        private static void ConfigureRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new List<IdentityRole>() {
                        new IdentityRole("Admin")
                    });
        }

        private static void ConfigureUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasData(
                    new List<IdentityUserRole<Guid>>() {
                        new IdentityUserRole<Guid>()
                    }) ;
        }
    }
}

//"aff3b9d0-2e80-4582-923b-d238e5383b70",