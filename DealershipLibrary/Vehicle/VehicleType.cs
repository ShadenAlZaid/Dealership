using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DealershipLibrary
{
    public class VehicleType
    {
        public VehicleType(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
    public enum VehicleTypesEnum
    {
        Car = 1,
        Motorcycle = 2,
        Truck = 3,
    }
}
