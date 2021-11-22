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

        [Required(ErrorMessage = "Please Select a Type")]
        public VehicleType vehicleType { get; set; }

        public void SetVehicleType(string name)
        {
            this.vehicleType = new VehicleType(name);
        }
    }
    public enum VehicleTypesEnum
    {
        Car = 1,
        Motorcycle = 2,
        Truck = 3,
    }
}
