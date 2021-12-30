using System;
using System.Collections.Generic;
using DealershipLibrary;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog= DealershipData; ",
                options => options.MaxBatchSize(100));
            //.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
            //.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();
            modelBuilder.Entity<Motorcycle>();
            modelBuilder.Entity<Truck>();
            modelBuilder.Entity<VehicleColor>()
                .HasData(
                new List<VehicleColor>() {
                    new VehicleColor(VehicleColorId : 1, Name : "Black"),
                    new VehicleColor(VehicleColorId : 2, Name : "White"),
                    new VehicleColor(VehicleColorId : 3, Name : "Red"),
                    new VehicleColor(VehicleColorId : 4, Name : "Blue"),
                    new VehicleColor(VehicleColorId : 5, Name : "Silver")
                });
            modelBuilder.Entity<VehicleModel>().HasOne(v => v.VehicleType).WithMany(t => t.VehicleModels)
                .OnDelete(DeleteBehavior.Restrict)
                .HasData(
                new List<VehicleModel>() {
                    new VehicleModel(VehicleModelId : 1, Name : "Taurus"),
                    new VehicleModel(VehicleModelId : 2, Name : "Explorer"),
                    new VehicleModel(VehicleModelId : 3, Name : "Expedition"),
                    new VehicleModel(VehicleModelId : 4, Name : "Valkryie"),
                    new VehicleModel(VehicleModelId : 5, Name : "GoldWing"),
                    new VehicleModel(VehicleModelId : 6, Name : "Hurricane"),
                    new VehicleModel(VehicleModelId : 7, Name : "Silverado"),
                    new VehicleModel(VehicleModelId : 8, Name : "Tornado"),
                    new VehicleModel(VehicleModelId : 9, Name : "Ranger")
                });
            modelBuilder.Entity<VehicleType>().HasData(
                new List<VehicleType>() {
                    new VehicleType(VehicleTypeId : 1, Name : "Car"),
                    new VehicleType(VehicleTypeId : 2, Name : "Motorcycle"),
                    new VehicleType(VehicleTypeId : 3, Name : "Truck")
                });
        }
    }
}
