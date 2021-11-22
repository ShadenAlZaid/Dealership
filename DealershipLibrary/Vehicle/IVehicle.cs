using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicle
    {
        public VehicleColor VehicleColor { get; set; }
        public VehicleModel VehicleModel { get; set;}
    }
}