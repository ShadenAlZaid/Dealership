using DealershipLibrary.Vehicle;
using System;

namespace DealershipLibrary.Vehicle.Trucks
{
    public class Truck : VehicleBase
    {
        public int TruckId { get; set; }

        public Truck() { }
        public Truck(VehicleDTO truckDto)
        {
            Truck t = new Truck();
            t.VehicleModelId = truckDto.VehicleModelId;
            t.TruckId = truckDto.VehicleDTOId;
            t.VehicleType = truckDto.VehicleType;
            t.VehicleColorId = truckDto.VehicleColorId;
        }

        public Truck(string name, string color) : base(name, color)
        {
        }

        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

        //public void Clone(Truck truck)
        //{
        //    this.VehicleModel = new VehicleModel(truck.VehicleModel.Name);
        //    this.VehicleColor = new VehicleColor(truck.VehicleColor.Name);
        //}
    }
}