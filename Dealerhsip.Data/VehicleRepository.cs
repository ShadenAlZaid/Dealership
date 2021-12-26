using DealershipLibrary.Vehicle.Cars;
using DealershipLibrary.Vehicle.Motorcycles;
using DealershipLibrary.Vehicle.Trucks;
using System.Collections.Generic;
using DealershipLibrary;
using DealershipLibrary.Vehicle;
using System.Linq;

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
                if (v.VehicleType.Name == VehicleTypesEnum.Car.ToString())
                {
                    Car x = new Car(v);
                    _context.Cars.Add(x);
                }

                else if (v.VehicleType.Name == VehicleTypesEnum.Motorcycle.ToString())
                {
                    Motorcycle x = new Motorcycle(v);
                    _context.Motorcycles.Add(x);
                }
                else if (v.VehicleType.Name == VehicleTypesEnum.Truck.ToString())
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

        public List<LookupDTO> GetModels()
        {
            var models = _context.VehicleModels
                .Select(m => new LookupDTO(m.VehicleModelId, m.Name))
                .ToList();

            return models;
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
