using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Trucks
{
    public class Truck : VehicleBase, IVehicle
    {
        public Truck(string name, string color) : base(name, color)
        {
        }
        
        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

        public void Clone(Truck truck)
        {
            this.VehicleModel = new VehicleModel(truck.VehicleModel.Name);
            this.VehicleColor = new VehicleColor(truck.VehicleColor.Name);
        }
    }
} 