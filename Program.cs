using System;
using System.Collections.Generic;
using Dealership.Vehicle;
namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            //call vehicle factory   Design Patterns (factory pattern)
            VehicleFactory vehicleFactory = new VehicleFactory();

            vehicleFactory.VehicleFactoryOrder();
        }
    }
}