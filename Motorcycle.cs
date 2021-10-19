using System;

namespace Dealership
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle()
        {
        }

        public Motorcycle(string year, MCModels model, VehicleColors color) : base(year, model, color){

        }

        public void GetOptions() //EDIT FOR MOTORCYCLE
        {
            Console.WriteLine(" 1. RED\n 2. BLACK\n 3. WHITE\n 4. SILVER");
            Console.Write("Choose Color number: ");
            var choice1 = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice1;
            
            Console.WriteLine(" 1. VALKRYIE\n 2. GOLDWING\n 3. HURRICANE");
            Console.Write("Choose Model Number: ");
            var choice2 = int.Parse(Console.ReadLine());
            this.MModel = (MCModels) choice2;

            Console.Write("Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {MModel}";
        }
    }
}