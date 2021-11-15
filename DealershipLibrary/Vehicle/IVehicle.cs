using DealershipLibrary.Vehicle;

namespace DealershipLibrary
{
    public  interface IVehicle
    {
        public CarModels CModel { get; set; }
        public MCModels MModel { get; set; }
        public TModels TModel {get; set;}
        public CarColors carColor { get; set; }
        public MCColors mcColor { get; set; }
        public TColors tColor { get; set; }
        //public VehicleColors Color { get; set; }

    
    }
}