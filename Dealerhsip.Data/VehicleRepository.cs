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
        private readonly DealershipContext _context;

        public VehicleRepository(DealershipContext dealershipContext)
        {
            this._context = dealershipContext;
        }
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
    }
}
//.Select(m => new LookupDTO(m.VehicleModelId, m.Name))
