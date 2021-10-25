using System;
using System.Collections.Generic;
using DealershipLibrary.Vehicle;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            //call vehicle factory   Design Patterns (factory pattern)
            VehicleShowRoom vehicleFactory = new VehicleShowRoom();

            vehicleFactory.VehicleFactoryOrder();
        }
    }
}