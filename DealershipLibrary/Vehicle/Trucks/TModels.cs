using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipLibrary.Vehicle;

namespace DealershipLibrary{
    public class TModels : VehicleModels
    {
        List<string> truckModels = new List<string>();
        public string Name { get; set; }


    void list(){
        this.truckModels.Add("Silverado");
        this.truckModels.Add("Tornado");
        this.truckModels.Add("Ranger");
    
        foreach(var m in truckModels)
        {
            this.Name = m;
        } 
    }

    }    
}