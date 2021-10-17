namespace Dealership
{
    internal interface IVehicle
    {
        public CarModels Model { get; set; }
        public string Year { get; set; }
        public VehicleColors Color { get; set; }

        void GetOptions();
    }
}