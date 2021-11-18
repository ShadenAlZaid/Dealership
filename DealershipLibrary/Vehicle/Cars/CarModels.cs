using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public class CarModels : VehicleModels
    {
        List<string> carModels = new List<string>();
        public string modelName { get; set; }

        void list(){
            this.carModels.Add("Taurus");
            this.carModels.Add("Explorer");
            this.carModels.Add("Expedition");
            this.carModels.Add("Galaxy");

            foreach(var m in carModels)
            {
                this.modelName = m;
            }
        }
    }    
}
