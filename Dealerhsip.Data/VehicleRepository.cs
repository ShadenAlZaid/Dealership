using System.Linq;
using System.Collections.Generic;
using DealershipLibrary;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dealership.Data
{
    public class VehicleRepository : IVehicleRepository
    {
        private DealershipContext _context = new DealershipContext();

        public string SubmitToDB(List<VehicleDTO> ShoppingCart)
        {
            _context.Database.EnsureCreated();

            foreach (var v in ShoppingCart)
            {
                if (v.VehicleTypeId == (int)VehicleTypesEnum.Car)
                {
                    Car x = new Car(v);
                    _context.Cars.Add(x);
                }

                else if (v.VehicleTypeId == (int)VehicleTypesEnum.Motorcycle)
                {
                    Motorcycle x = new Motorcycle(v);
                    _context.Motorcycles.Add(x);
                }
                else if (v.VehicleTypeId == (int)VehicleTypesEnum.Truck)
                {
                    Truck x = new Truck(v);
                    _context.Trucks.Add(x);
                }
            }
            _context.SaveChanges();
            string purchaseMsg = "Purchase Successful!";
            return purchaseMsg;
        }

        public List<LookupDTO> GetColors()
        {
            var colors = _context.VehicleColors
                .Select(c => new LookupDTO(c.VehicleColorId, c.Name))
                .ToList();

            return colors;
        }

        public List<LookupDTO> GetModels(Type x)
        {
            List<LookupDTO> models;
            if (x == typeof(Car))
            {
                models = null;
                models = _context.VehicleModels
               .Where(m => m.VehicleTypeId == 1)
               .Select(c => new LookupDTO(c.VehicleModelId, c.Name))
               .ToList();
                return models;
            }
            else if (x == typeof(Motorcycle))
            {
                models = null;
                models = _context.VehicleModels
               .Where(m => m.VehicleTypeId == 1)
               .Select(c => new LookupDTO(c.VehicleModelId, c.Name))
               .ToList();
                return models;
            }
            else if (x == typeof(Truck))
            {
                models = null;
                models = _context.VehicleModels
               .Where(m => m.VehicleTypeId == 1)
               .Select(c => new LookupDTO(c.VehicleModelId, c.Name))
               .ToList();
                return models;
            }
            else
                return null;
        }

        public List<LookupDTO> GetTypes()
        {
            var types = _context.VehicleTypes
                .Select(t => new LookupDTO(t.VehicleTypeId, t.Name))
                .ToList();

            return types;
        }
    }
}
//.Select(m => new LookupDTO(m.VehicleModelId, m.Name))
