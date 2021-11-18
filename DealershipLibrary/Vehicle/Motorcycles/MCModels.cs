using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class MCModels : VehicleModels
    {
        List<string> motorcycleModels = new List<string>();

        void list(){
            this.motorcycleModels.Add("Valkryie");
            this.motorcycleModels.Add("GoldWing");
            this.motorcycleModels.Add("Hurricane");
        }

    }    

}
    
