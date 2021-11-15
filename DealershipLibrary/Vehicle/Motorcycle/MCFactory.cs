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
            Extensions.GetEnumItems(typeof(MCColors));

            var choice1 = (int)(Extensions.GetSelectedOptions<MCColors>());
            MC.mcColor = (MCColors) choice1;

            Extensions.GetEnumItems(typeof(MCModels));

            var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            MC.mcModel = (MCModels) choice2;

            return MC;
       }
    }
}
