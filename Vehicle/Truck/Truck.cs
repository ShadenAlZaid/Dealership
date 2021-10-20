using Dealership.Vehicle;
using System;

namespace Dealership
{
    class Truck : VehicleBase, IVehicle
    
    {
        public Truck(){}

        public Truck(string year, TModels model, VehicleColors color) : base(year, model, color){

        }
        public void GetOptions()
        {
            Extensions.PrintEnum(typeof(VehicleColors));
            
            Console.Write("\nChoose Color number: ");
            var choice1 = (int)(Extensions.GetSelectedOptions<VehicleColors>());
            this.Color = (VehicleColors)choice1;

            Extensions.PrintEnum(typeof(TModels));
            
            Console.Write("\nChoose Model Number: ");
            var choice2 = (int)(Extensions.GetSelectedOptions<TModels>());
            this.TModel = (TModels)choice2;

            Console.Write("\nEnter Year: ");
            this.Year = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Year} {Color} {TModel}";
        }
    }
} 