using DealershipLibrary.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle.Trucks
{

    public class TruckFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            IVehicle Truck = new Truck(null, null);

            Extensions.GetEnumItems(typeof(TruckModelsEnum));

            return Truck;
        }
    }
}
