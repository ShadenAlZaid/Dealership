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
            foreach(int i in Enum.GetValues(typeof(VehicleColors)))
            {  
                Console.WriteLine($"{i}. {Enum.GetName(typeof(VehicleColors), i)}");  
            }            
            
            Console.Write("Choose Color number: ");
            var choice1 = int.Parse(Console.ReadLine());
            this.Color = (VehicleColors) choice1;
            
            foreach(int i in Enum.GetValues(typeof(TModels)))
            {  
                Console.WriteLine($"{i}. {Enum.GetName(typeof(TModels), i)}");  
            }            
            
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