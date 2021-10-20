using System;
using System.Collections.Generic;

namespace Dealership.Vehicle
{
    class VehicleFactory
    {
        public VehicleFactory(){}

        public void VehicleFactoryOrder()
        {

            var shoppingCart = new List<IVehicle>();
            IVehicle vehicle = null;

            Console.WriteLine("\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("WELCOME TO OUR VEHICLE DEALERSHIP!\n\n");
            Console.WriteLine("WHAT ARE YOU INTERESTED IN?");
            
            Extensions.PrintEnum(typeof(VehicleTypes));

            Console.WriteLine("**********************************");
            Console.WriteLine("\n");
            Console.Write("Enter you choice number: ");
            
            var choice = (int)(Extensions.GetSelectedOptions<VehicleTypes>());
            var type = (VehicleTypes)choice;

            //Apply SOLID   learn(SO) in solid
            switch (type)
            {
                case VehicleTypes.Car:
                    vehicle = new Car();
                    break;
                case VehicleTypes.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
                case VehicleTypes.Truck:
                    vehicle = new Truck();
                    break;
                default:
                    break;
            }

            vehicle.GetOptions();
            Console.Write(vehicle.ToString());

            shoppingCart.Add(vehicle);

        }

    }
}