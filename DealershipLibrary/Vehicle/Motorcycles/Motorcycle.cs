using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase, IVehicle
    {
        public Motorcycle(){}

        public Motorcycle(MCModels model, VehicleColors color) : base(model, color){
        }

        public override string ToString()
        {
            return $"{color} {mcModel}";
        }
    }
}