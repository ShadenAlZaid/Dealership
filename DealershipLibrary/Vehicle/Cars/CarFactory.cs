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

            Console.WriteLine( string.Join("\t", Extensions.GetEnumItems(typeof(VehicleColors))));

            //Get)SelectedOptions double checks option is in enu, list 
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());

            car.Color = (VehicleColors)choice1;

            Extensions.PrintEnum(typeof(CarModels));

            var choice2 = (int)(Extensions.GetSelectedOptions<CarModels>());

            car.CModel = (CarModels)choice2;

            Console.Write("\nEnter Year: ");

            car.Year = Console.ReadLine();

            return car;
        }
    }
}
