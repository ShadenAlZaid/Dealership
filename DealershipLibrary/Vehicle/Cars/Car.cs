using System;
using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace DealershipLibrary.Vehicle.Cars
{
    public class Car : VehicleBase, IVehicle
    {
        public Car(){}

        public Car(VehicleModels modelName, VehicleColors color) : base(modelName, color)
        {
        }

        public override string ToString()
        {
            return $"{color} {Model}";
        }
    }
}