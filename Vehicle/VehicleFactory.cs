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

            // VehiclesList.Add(C);

            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("WELCOME TO OUR VEHICLE DEALERSHIP!\n\n");
            Console.WriteLine("WHAT ARE YOU INTERESTED IN?");
            
            foreach(int i in Enum.GetValues(typeof(VehicleTypes)))
            {  
                Console.WriteLine($"{i}. {Enum.GetName(typeof(VehicleTypes), i)}");  
            }

            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");
            Console.Write("Enter you choice number: ");
            var choice = int.Parse(Console.ReadLine());
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