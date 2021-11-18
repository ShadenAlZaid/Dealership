using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class CarModels : VehicleModels
    {
        List<string> carModels = new List<string>();

        void list(){
            this.carModels.Add("Taurus");
            this.carModels.Add("Explorer");
            this.carModels.Add("Expedition");
            this.carModels.Add("Galaxy");

        }
    }    
}
