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
            //Prints menu options
            Extensions.PrintEnum(typeof(VehicleColors));

            Console.Write("\nChoose Color number: ");

            //GetSelectedOptions double checks option is in enu, list 
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            this.Color = (VehicleColors)choice1;

            Extensions.PrintEnum(typeof(CarModels));

            Console.Write("\nChoose Model Number: ");
            var choice2 = (int)(Extensions.GetSelectedOptions<CarModels>());
            this.CModel = (CarModels)choice2;

            Console.Write("\nEnter Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {CModel}";
        }
    }


}