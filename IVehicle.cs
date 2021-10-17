namespace Dealership
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public VehicleColors Color { get; set; }

        void GetOptions();
    }
}