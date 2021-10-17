using System;
using System.Collections.Generic;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            //call vehicle factory
            VehicleFactory v = new VehicleFactory();
            v.VehicleFactoryCall();
        }
    }
}