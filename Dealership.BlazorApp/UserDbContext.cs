using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dealership.BlazorApp.Data
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
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
                        new IdentityUser<Guid>(){ Id = Guid.Parse("aff3b9d0-2e80-4582-923b-d238e5383b70"), UserName = "Admin77"}
                    });
        }

        private static void ConfigureRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole<Guid>>()
                .HasData(
                    new List<IdentityRole<Guid>>() {
                        new IdentityRole<Guid>(){ Id = Guid.Parse("91448306-d971-40c4-b8d8-4bd869b20687"), Name = "Admin" }
                    });
        }

        private static void ConfigureUserRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasNoKey();
            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasData(
                    new List<IdentityUserRole<Guid>>() {
                        new IdentityUserRole<Guid>(){UserId = Guid.Parse("aff3b9d0-2e80-4582-923b-d238e5383b70"), RoleId = Guid.Parse("91448306-d971-40c4-b8d8-4bd869b20687")}
                    });
        }
    }
}
