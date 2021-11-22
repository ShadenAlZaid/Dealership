using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase, IVehicle
    {
    
        public Motorcycle(IVehicleModel modelName, VehicleColors color) : base(modelName.ToString(), color){
        }

        public override string ToString()
        {
            return $"{color} {VehicleModel?.Name}";
        }
    }
}