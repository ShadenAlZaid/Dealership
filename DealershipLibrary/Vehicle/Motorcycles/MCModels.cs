using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public class MCModels : VehicleModels
    {
        List<string> motorcycleModels = new List<string>();
        public string Name { get; set; }

        void list(){
            this.motorcycleModels.Add("Valkryie");
            this.motorcycleModels.Add("GoldWing");
            this.motorcycleModels.Add("Hurricane");        
            
            foreach(var m in motorcycleModels)
            {
                this.Name = m;
            }
        }
    }    
}
    
