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
            IVehicle car = new Car();
       
            //GetSelectedOptions double checks option is in enum list 
            // var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());

            // car.color = (VehicleColors)choice1;

            // var choice2 = (int)(Extensions.GetSelectedOptions<CarModels>());


            // car.carModel = (CarModels)choice2;

            Extensions.GetEnumItems(typeof(CarModels));

            return car;
        }
    }
}
