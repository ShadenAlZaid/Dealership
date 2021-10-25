using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary{

    public class MCFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle MC = new Motorcycle();
            Extensions. PrintEnum(typeof(VehicleColors));

            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            MC.Color = (VehicleColors) choice1;

            Extensions.PrintEnum(typeof(MCModels));

            var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            MC.MModel = (MCModels) choice2;

            Console.Write("\nEnter Year: ");
            MC.Year = Console.ReadLine(); 

            return MC;
       }
    }
}
