using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle.Trucks{

    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle Truck = new Truck();
            // Extensions.GetEnumItems(typeof(VehicleColors));

            // var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            // Truck.color = (VehicleColors) choice1;


            // var choice2 = VehicleModels.name;
            // Truck.tModel = (VehicleModels) choice2;
            Extensions.GetEnumItems(typeof(VehicleModels));

            return Truck;
       }
    }
}
