using System;
using System.Collections.Generic;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {            
            var  shoppingCart = new List<IVehicle>();
            IVehicle vehicle= null;  

           // VehiclesList.Add(C);
            
            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("WELCOME TO OUR VEHICLE DEALERSHIP!");
            Console.WriteLine("WHAT ARE YOU INTERESTED IN?");
            Console.WriteLine("1. Enter 1 for CARS \n2. MOTORCYCLES \n3. TRUCKS");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");

            Console.Write("Enter your choice: ");
            var choice = int.Parse(Console.ReadLine());
            var type =(VehicleTypes) choice;

            switch (type)  //Apply SOLID
            {
                case VehicleTypes.Car:
                    vehicle = new Car();

                    break;
                case VehicleTypes.MC:

                    break;
                case VehicleTypes.Truck:
                    break;
                case VehicleTypes.Bicycle:
                    break;
                default:
                    break;
            }
            
            vehicle.GetOptions();

            shoppingCart.Add(vehicle);

          //  Console.WriteLine(C.ToString());
        }
    }
}