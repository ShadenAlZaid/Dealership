using System;

namespace Dealership
{
    class Car : VehicleBase, IVehicle
    {

        public Car()
        {

        }
        public Car(string year, string make, string model, string color, string cost, string availability) : base(year, make, model, color, cost, availability)
        {

        }

        public void GetOptions()
        {
            Console.WriteLine("Color:");

            this.Color = Console.ReadLine();

            Console.WriteLine("Make:");

            this.Make = Console.ReadLine();
        }


        public override string ToString()
        {
            return $"{Year} {Color} {Make} {Model} RENTED for {Cost}!";
        }
    }


}