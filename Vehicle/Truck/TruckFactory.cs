using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Vehicle.Cars{

    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle Truck = new Truck();
            Extensions. PrintEnum(typeof(VehicleColors));

            Console.Write("\nChoose Color number: ");
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            Truck.Color = (VehicleColors) choice1;

            Extensions.PrintEnum(typeof(MCModels));

            Console.Write("\nChoose Model Number: ");
            var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            Truck.MModel = (MCModels) choice2;

            Console.Write("\nEnter Year: ");
            Truck.Year = Console.ReadLine(); 

            return Truck;
       }
    }
}
