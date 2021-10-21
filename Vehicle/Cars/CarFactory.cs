using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Vehicle.Cars
{
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle car = new Car();
            Extensions.PrintEnum(typeof(VehicleColors));

            Console.Write("\nChoose Color number: ");

            //GetSelectedOptions double checks option is in enu, list 
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            car.Color = (VehicleColors)choice1;

            Extensions.PrintEnum(typeof(CarModels));

            Console.Write("\nChoose Model Number: ");
            var choice2 = (int)(Extensions.GetSelectedOptions<CarModels>());
            car.CModel = (CarModels)choice2;

            Console.Write("\nEnter Year: ");
            car.Year = Console.ReadLine();

            return car;
        }
    }
}
