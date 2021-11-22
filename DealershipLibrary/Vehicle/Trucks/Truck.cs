using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Trucks
{
    public class Truck : VehicleBase, IVehicle
    
    {
     
        public Truck(IVehicleModel modelName, VehicleColors color) : base(modelName.ToString(), color){

        }
        
        public override string ToString()
        {
            return $"{color} {VehicleModel?.Name}";
        }
    }
} 