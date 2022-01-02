using DealershipLibrary.Vehicle.Motorcycles;
using System;

namespace DealershipLibrary.Vehicle.Motorcycles
{
    public class Motorcycle : VehicleBase
    {
        public int MotorcycleId { get; set; }

        public Motorcycle() { }

        public Motorcycle(VehicleDTO motorcycleDto)
        {
            this.VehicleModelId = motorcycleDto.VehicleModelId;
            this.MotorcycleId = motorcycleDto.VehicleDTOId;
            this.VehicleTypeId = motorcycleDto.VehicleTypeId;
            this.VehicleColorId = motorcycleDto.VehicleColorId;
        }
        public Motorcycle(string name, string color) : base(name, color)
        {
        }
        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

        //public void Clone(Motorcycle motorcycle)
        //{
        //    this.VehicleModel = new VehicleModel(motorcycle.VehicleModel.Name);
        //    this.VehicleColor = new VehicleColor(motorcycle.VehicleColor.Name);
        //}
    }
}