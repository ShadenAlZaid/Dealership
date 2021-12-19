namespace DealershipLibrary.Vehicle.Cars
{
    public class Car : VehicleBase, IVehicle
    {
        public int CarId { get; set; } 

        public Car() { }
        public Car(string name, string color) : base(name, color)
        {
        }

        public override string ToString()
        {
            return $"{VehicleColor?.Name} {VehicleModel?.Name}";
        }

        public void Clone(Car car)
        {
            this.VehicleModel = new VehicleModel(car.VehicleModel.Name);
            this.VehicleColor = new VehicleColor(car.VehicleColor.Name);
        }
    }
}