using Dealership.Vehicle;
using System;

namespace Dealership
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle(){}

        public Motorcycle(string year, MCModels model, VehicleColors color) : base(year, model, color){
        }

        public override string ToString()
        {
            return $"{Year} {Color} {MModel}";
        }
    }
}