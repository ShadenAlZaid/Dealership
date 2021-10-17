namespace Dealership
{
    internal interface IVehicle
    {
        public string Cost { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }

        void GetOptions();
    }
}