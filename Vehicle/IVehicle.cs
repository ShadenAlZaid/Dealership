using Dealership.Vehicle;

namespace Dealership
{
    internal interface IVehicle
    {
        public CarModels CModel { get; set; }
        public MCModels MModel { get; set; }
        public TModels TModel {get; set;}
        public string Year { get; set; }
        public VehicleColors Color { get; set; }

        void GetOptions();
    
    }
}