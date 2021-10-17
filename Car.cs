using System;

namespace Dealership
{
    class Car : VehicleBase, IVehicle
    {
        
        public Car()
        {

        }
        public Car(string year, string model, VehicleColors color) : base(year, model, color)
        {

        }

        public void GetOptions()
        {
            Console.Write("Year: ");
            this.Year = Console.ReadLine();

            Console.WriteLine(" 1. RED\n 2. BLACK\n 3. WHITE\n 4. SILVER");
            Console.Write("Choose Color number: ");

            //this.Color = Console.ReadLine();
            var choice = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice;

            Console.Write("Model: ");

            this.Model = Console.ReadLine();
        }


        public override string ToString()
        {
            return $"{Year} {Color} {Model}";
        }
    }


}