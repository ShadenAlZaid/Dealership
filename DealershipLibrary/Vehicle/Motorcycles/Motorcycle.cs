using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase, IVehicle
    {
        public Motorcycle(){}

        public Motorcycle(VehicleModels modelName, VehicleColors color) : base(modelName, color){
        }

        public override string ToString()
        {
            return $"{color} {Model}";
        }
    }
}