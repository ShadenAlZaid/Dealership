using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary
{
    class Truck : VehicleBase, IVehicle
    
    {
        public Truck(){}

        public Truck(TModels model, TColors color) : base(model, color){

        }
        
        public override string ToString()
        {
            return $"{tColor} {tModel}";
        }
    }
} 