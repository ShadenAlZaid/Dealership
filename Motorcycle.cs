using System;

namespace Dealership
{
    class Motorcycle : VehicleBase, IVehicle
{
        public Motorcycle(string year, CarModels model, VehicleColors color) : base(year, model, color){

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