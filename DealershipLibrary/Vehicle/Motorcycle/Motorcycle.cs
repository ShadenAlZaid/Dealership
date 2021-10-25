using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary
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