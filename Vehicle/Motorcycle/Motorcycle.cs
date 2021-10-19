using Dealership.Vehicle;
using System;

namespace Dealership
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle(){}

        public Motorcycle(string year, MCModels model, VehicleColors color) : base(year, model, color){

        }

        public void GetOptions() //EDIT FOR MOTORCYCLE
        {
           Extensions. PrintEnum(typeof(VehicleColors));

            Console.Write("Choose Color number: ");
            var choice1 = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice1;

            Extensions.PrintEnum(typeof(MCModels));

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