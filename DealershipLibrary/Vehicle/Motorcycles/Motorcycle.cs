using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase
    {
        public int MotorcycleId { get; set; }

        public Motorcycle() { }

        public Motorcycle(VehicleDTO motorycyleDto)
        {

        }
        public Motorcycle(string name, string color) : base(name, color)
        {
        }
        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

        public void Clone(Motorcycle motorcycle)
        {
            this.VehicleModel = new VehicleModel(motorcycle.VehicleModel.Name);
            this.VehicleColor = new VehicleColor(motorcycle.VehicleColor.Name);
        }
    }
}