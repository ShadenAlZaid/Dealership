using Dealership.Vehicle;
using System;

namespace Dealership
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle(){}

        public Motorcycle(string year, MCModels model, VehicleColors color) : base(year, model, color){

        }

        public void GetOptions() 
        {
           Extensions. PrintEnum(typeof(VehicleColors));

            Console.Write("\nChoose Color number: ");
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            this.Color = (VehicleColors) choice1;

            Extensions.PrintEnum(typeof(MCModels));

            Console.Write("\nChoose Model Number: ");
            var choice2 = (int)(Extensions.GetSelectedOptions<MCModels>());
            this.MModel = (MCModels) choice2;

            Console.Write("\nEnter Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {MModel}";
        }
    }
}