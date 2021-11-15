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
            Extensions.GetEnumItems(typeof(VehicleColors));

            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            Truck.tColor = (TColors) choice1;

            Extensions.GetEnumItems(typeof(MCModels));

            var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            Truck.tModel = (TModels) choice2;

            return Truck;
       }
    }
}
