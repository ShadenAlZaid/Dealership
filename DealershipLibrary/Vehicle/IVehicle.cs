using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public interface IVehicle
    {
        // public CarModels carModel {get; set;}
        // public MCModels mcModel {get; set;}
        // public TModels tModel {get; set;}
        // public CarColors carColor {get; set;}
        // public MCColors mcColor {get; set;}
        // public TColors tColor {get; set;}
        public VehicleColors color { get; set; }
        public VehicleModels modelName {get; set;}
    }
}