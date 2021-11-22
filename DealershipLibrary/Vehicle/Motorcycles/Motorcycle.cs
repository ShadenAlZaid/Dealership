using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase, IVehicle
    {
        public Motorcycle(string name, string color) : base(name, color)
        {
        }

        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }
    }
}