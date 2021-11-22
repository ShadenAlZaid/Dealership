using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle.Motorcycles{

    public class MCFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle MC = new Motorcycle(null, VehicleColors.White);
            // Extensions.GetEnumItems(typeof(VehicleColors));

            // var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            // MC.color = (VehicleColors) choice1;


            // var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            // MC.mcModel = (MCModels) choice2;
            
            Extensions.GetEnumItems(typeof(IVehicleModel));

            return MC;
       }
    }
}
