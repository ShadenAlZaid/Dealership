using System;

namespace Dealership
{
    class Truck : VehicleBase, IVehicle
    
    {
        public Truck()
        {
        }

        public Truck(string year, TModels model, VehicleColors color) : base(year, model, color){

        }
        public void GetOptions()
        {
            Console.WriteLine(" 1. RED\n 2. BLACK\n 3. WHITE\n 4. SILVER");
            Console.Write("Choose Color number: ");
            var choice1 = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice1;
            
            Console.WriteLine(" 1. SLVERADO\n 2. TORNADO\n 3. RANGER");
            Console.Write("Choose Model Number: ");
            var choice2 = int.Parse(Console.ReadLine());
            this.TModel = (TModels) choice2;

            Console.Write("Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {TModel}";
        }
    }
} 