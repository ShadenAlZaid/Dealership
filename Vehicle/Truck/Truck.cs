using Dealership.Vehicle;
using System;

namespace Dealership
{
    class Truck : VehicleBase, IVehicle
    
    {
        public Truck(){}

        public Truck(string year, TModels model, VehicleColors color) : base(year, model, color){

        }
        
        public override string ToString()
        {
            return $"{Year} {Color} {TModel}";
        }
    }
} 