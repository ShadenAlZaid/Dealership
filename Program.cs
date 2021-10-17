using System;
using System.Collections.Generic;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Vehicles> VehiclesList = new List<Vehicles>();
            Vehicles C = new Car("1999", "Toyota", "Camry", "white", "$1000", "Yes");

            VehiclesList.Add(C);
            
            Console.WriteLine("\n\n");
            Console.WriteLine("**********************************");
            Console.WriteLine("WELCOME TO OUR VEHICLE DEALERSHIP!");
            Console.WriteLine("WHAT ARE YOU INTERESTED IN?");
            Console.WriteLine("1. CARS \n2. MOTORCYCLES \n3. TRUCKS");
            Console.WriteLine("**********************************");
            Console.WriteLine("\n\n");

            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();
            choice = choice.ToUpper();

            switch(choice){
                case "1":
                case "CAR":
                    C.RentVehicle();
                    Console.WriteLine(C.ToString());
                    break;
                case "2":
                case "MOTORCYCLE":
                    C.RentVehicle();
                    Console.WriteLine(C.ToString());
                    break;
                case "3":
                case "TRUCK":
                    C.RentVehicle();
                    Console.WriteLine(C.ToString());                   
                    break;                                                 
                default:
                    break;
            }
        }
    }
}