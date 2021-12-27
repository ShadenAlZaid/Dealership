using System;
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
            modelBuilder.Entity<VehicleColor>();
            modelBuilder.Entity<VehicleModel>();

            modelBuilder.Entity<VehicleType>()
             .HasOne(m => m.VehicleType)
             .WithMany(t => t.VehicleModel);

        }
    }
}
