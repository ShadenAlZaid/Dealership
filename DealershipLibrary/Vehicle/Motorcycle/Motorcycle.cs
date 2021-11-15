using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle(){}

        public Motorcycle(MCModels model, MCColors color) : base(model, color){
        }

        public override string ToString()
        {
            return $"{mcColor} {mcModel}";
        }
    }
}