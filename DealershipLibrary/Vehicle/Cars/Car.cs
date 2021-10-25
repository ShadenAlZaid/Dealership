using System;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace  DealershipLibrary.Vehicle.Cars

{
    public class Car : VehicleBase, IVehicle
    {
        public Car() { }

        public Car(string year, CarModels model, VehicleColors color) : base(year, model, color)
        {
        }
        public override string ToString()
        {
            return $"{Year} {Color} {CModel}";
        }
    }


}