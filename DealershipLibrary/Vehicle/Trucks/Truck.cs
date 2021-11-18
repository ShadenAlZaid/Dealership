using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Trucks
{
    public class Truck : VehicleBase, IVehicle
    
    {
        public Truck(){}

        public Truck(VehicleModels modelName, VehicleColors color) : base(modelName, color){

        }
        
        public override string ToString()
        {
            return $"{color} {modelName}";
        }
    }
} 