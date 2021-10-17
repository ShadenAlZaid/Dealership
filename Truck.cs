using System;

namespace Dealership
{
    class Truck : VehicleBase, IVehicle
    
    {
        public Truck()
        {
        }

        public Truck(string year, CarModels model, VehicleColors color) : base(year, model, color){

        }

        public void GetOptions()
        {
            throw new NotImplementedException();
        }

        // public override string ToString()
        // {
        //     return $"{year} {color} {model}";
        // }
    }
} 