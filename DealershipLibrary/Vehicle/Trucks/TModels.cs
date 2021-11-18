using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary{
    public class TModels : VehicleModels
    {
        List<string> truckModels = new List<string>();

    void list(){
        this.truckModels.Add("Silverado");
        this.truckModels.Add("Tornado");
        this.truckModels.Add("Ranger");
    }

    }    
}