using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle
{
    public class VehicleModel
    {
        public int VehicleModelId { get; set; }
        public VehicleModel(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
