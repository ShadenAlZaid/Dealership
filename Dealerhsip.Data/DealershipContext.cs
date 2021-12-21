using System;
using DealershipLibrary;
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Dealerhsip.Data
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
            optionsBuilder.UseSqlServer("Data Source= .; Initial Catalog=DealershipData;integrated security=true;",
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
            modelBuilder.Entity<VehicleType>();
        }

        //private static void InsertVehicleIntoDB()
        //{
        //    IVehicle car = new Car(null, null);
        //    IVehicle motorcycle = new Motorcycle(null, null);
        //    IVehicle truck = new Truck(null, null);

        //    _context.Trucks.Add((Truck)truck);
        //    _context.Cars.Add((Car)car);
        //    _context.Motorcycles.Add((Motorcycle)motorcycle);
        //    _context.SaveChanges();
        //}

    }
}
