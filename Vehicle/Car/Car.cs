using System;
using Dealership.Vehicle;



namespace Dealership.Vehicle
{
    class Car : VehicleBase, IVehicle
    {
        public Car() { }

        public Car(string year, CarModels model, VehicleColors color) : base(year, model, color)
        {
        }

        public void GetOptions()
        {

            Extensions.PrintEnum(typeof(VehicleColors));

            Console.Write("Choose Color number: ");

            var choice1 = (int)(Extensions.GetOptions<VehicleColors>());

            this.Color = (VehicleColors)choice1;

            Extensions.PrintEnum(typeof(CarModels));

            Console.Write("Choose Model Number: ");
            var choice2 = int.Parse(Console.ReadLine());
            this.CModel = (CarModels)choice2;

            Console.Write("Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {CModel}";
        }
    }


}