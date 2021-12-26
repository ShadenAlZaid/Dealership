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

        public string RetrieveVehicleColorsFromDB()
        {
            var Colors = _context.VehicleColors.ToList();
            foreach (var color in Colors)
            {
                return color.Name;
            }
            return "no colors";
        }

        public string RetrieveVehicleTypesFromDB()
        {
            return "";
        }
    }
}
