using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary
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