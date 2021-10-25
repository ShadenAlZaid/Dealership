using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary{

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
            Truck.TModel = (TModels) choice2;

            Console.Write("\nEnter Year: ");
            Truck.Year = Console.ReadLine(); 

            return Truck;
       }
    }
}
