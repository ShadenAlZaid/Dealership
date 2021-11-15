using System;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace DealershipLibrary.Vehicle.Cars
{
    public class Car : VehicleBase, IVehicle
    {
        public Car(){}

        public Car(CarModels model, CarColors color) : base(model, color)
        {
        }

        public override string ToString()
        {
            return $"{Color} {CModel}";
        }
    }


}