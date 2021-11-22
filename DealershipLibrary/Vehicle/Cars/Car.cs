using System;
using System.ComponentModel.DataAnnotations;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace DealershipLibrary.Vehicle.Cars
{
    public class Car : VehicleBase, IVehicle
    {
       

        public Car(string name, VehicleColors color) : base( name, color)
        {
        }
 

        public override string ToString()
        {
            return $"{color} {VehicleModel?.Name}";
        }
    }
}