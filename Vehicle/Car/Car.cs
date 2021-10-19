using System;

namespace Dealership
{
    class Car : VehicleBase, IVehicle
    {
        
        public Car()
        {

        }
        public Car(string year, CarModels model, VehicleColors color) : base(year, model, color)
        {

        }

        public void GetOptions()
        {
            Console.WriteLine(" 1. RED\n 2. BLACK\n 3. WHITE\n 4. SILVER");
            Console.Write("Choose Color number: ");
            var choice1 = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice1;
            
            Console.WriteLine(" 1. TAURUS\n 2. EXPLORER\n 3. EXPEDITION\n 4. GALAXY");
            Console.Write("Choose Model Number: ");
            var choice2 = int.Parse(Console.ReadLine());
            this.CModel = (CarModels) choice2;

            Console.Write("Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {CModel}";
        }
    }


}