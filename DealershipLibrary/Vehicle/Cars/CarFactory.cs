using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle.Cars 
{ 
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle car = new Car( null, null);

            Extensions.GetEnumItems(typeof(CarModelsEnum));

            return car;
        }
    }
}
