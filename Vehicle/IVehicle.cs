using Dealership.Vehicle;
using Dealership.Vehicle.Cars;

namespace Dealership
{
    public  interface IVehicle
    {
        public CarModels CModel { get; set; }
        public MCModels MModel { get; set; }
        public TModels TModel {get; set;}
        public string Year { get; set; }
        public VehicleColors Color { get; set; }

    
    }
}