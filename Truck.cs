using System;

namespace Dealership
{
    class Truck : Vehicles{
        public Truck(string year, string make, string model, string color, string cost, string availability) : base(year, make, model, color, cost, availability){

        }

        public override string ToString()
        {
            return $"{year} {color} {make} {model} RENTED for {cost}!";
        }
    }
} 