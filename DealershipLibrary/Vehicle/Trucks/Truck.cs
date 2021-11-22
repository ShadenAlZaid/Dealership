using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Trucks
{
    public class Truck : VehicleBase, IVehicle
    {
        public Truck(string name, string color) : base(name, color)
        {
        }
        
        public override string ToString()
        {
            return $"{VehicleColors?.Name} {VehicleModel?.Name}";
        }
    }
} 