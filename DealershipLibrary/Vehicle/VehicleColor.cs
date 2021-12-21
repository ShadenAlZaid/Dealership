using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary.Vehicle
{
    public class VehicleColor
    {
        public int VehicleColorId { get; set; }
        public VehicleColor(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}