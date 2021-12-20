using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicle
    {
        public VehicleType VehicleType { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public VehicleModel VehicleModel { get; set; }
    }
}