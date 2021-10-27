using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace DealershipLibrary
{
    public  interface IVehicle
    {
        public CarModels CModel { get; set; }
        public MCModels MModel { get; set; }
        public TModels TModel {get; set;}
        public VehicleColors Color { get; set; }

    
    }
}