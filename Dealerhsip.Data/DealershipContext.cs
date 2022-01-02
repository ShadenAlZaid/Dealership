using System;
using System.Collections.Generic;
using DealershipLibrary;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
using Microsoft.EntityFrameworkCore;
using Dealership.BlazorApp.Startup;
using Microsoft.Extensions.Logging;

namespace Dealership.Data
{
    public class DealershipContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<VehicleColor> VehicleColors { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var con = GetConnectionString();
                optionsBuilder.UseSqlServer(con);
            }
            //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= DealershipData; ",
            //    options => options.MaxBatchSize(100));
            //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            //.EnableSensitiveDataLogging();
        }
        public static string GetConnectionString()
        {
            return Startup.ConnectionString;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureMainEntities(modelBuilder);
            ConfigureVehicleColor(modelBuilder);
            ConfigureVehicleModel(modelBuilder);
            ConfigureVehicleType(modelBuilder);
        }


        private static void ConfigureVehicleType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>()
                .HasData(
                    new List<VehicleType>() {
                        new VehicleType(VehicleTypeId : 1, Name : "Car"),
                        new VehicleType(VehicleTypeId : 2, Name : "Motorcycle"),
                        new VehicleType(VehicleTypeId : 3, Name : "Truck")
                    }
                 );
        }

        private static void ConfigureVehicleModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleModel>().HasOne(v => v.VehicleType).WithMany(t => t.VehicleModels)
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<VehicleModel>()
               .HasData(
                    new List<VehicleModel>() {
                        new VehicleModel(1, "Taurus", 1),
                        new VehicleModel(2, "Explorer", 1),
                        new VehicleModel(3, "Expedition", 1),
                        new VehicleModel(4, "Valkryie", 2),
                        new VehicleModel(5, "GoldWing", 2),
                        new VehicleModel(6, "Hurricane", 2),
                        new VehicleModel(7, "Silverado", 3),
                        new VehicleModel(8, "Tornado", 3),
                        new VehicleModel(9, "Ranger", 3)
                    }
               );
        }

        private static void ConfigureMainEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();
            modelBuilder.Entity<Motorcycle>();
            modelBuilder.Entity<Truck>();
        }

        private static void ConfigureVehicleColor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleColor>()
                .HasData(
                    new List<VehicleColor>() {
                        new VehicleColor(VehicleColorId : 1, Name : "Black"),
                        new VehicleColor(VehicleColorId : 2, Name : "White"),
                        new VehicleColor(VehicleColorId : 3, Name : "Red"),
                        new VehicleColor(VehicleColorId : 4, Name : "Blue"),
                        new VehicleColor(VehicleColorId : 5, Name : "Silver")
                    }
                );
        }
    }
}
