using System;

namespace Dealership
{
    class Motorcycle : VehicleBase,        IVehicle
{
        public Motorcycle(string year, string make, string model, string color, string cost, string availability) : base(year, make, model, color, cost, availability){

        }

        public void GetOptions()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "";//$"{year} {color} {make} {model} RENTED for {cost}!";
        }
    }
}