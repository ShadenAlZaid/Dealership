using System;
using System.Collections.Generic;

namespace Dealership{
    class VehicleFactory {

        public VehicleFactory(){

        }

        public void VehicleFactoryCall(){
                                
                var  shoppingCart = new List<IVehicle>();
                IVehicle vehicle= null;  

            // VehiclesList.Add(C);
                
                Console.WriteLine("\n\n");
                Console.WriteLine("**********************************");
                Console.WriteLine("WELCOME TO OUR VEHICLE DEALERSHIP!\n\n");
                Console.WriteLine("WHAT ARE YOU INTERESTED IN?");
                Console.WriteLine("1. CARS \n2. MOTORCYCLES \n3. TRUCKS");
                Console.WriteLine("**********************************");
                Console.WriteLine("\n\n");

                Console.Write("Enter you choice number: ");
                var choice = int.Parse(Console.ReadLine());
                var type = (VehicleTypes) choice;

                switch (type)  //Apply SOLID   learn(SO) in sloid
                {
                    case VehicleTypes.Car:
                        vehicle = new Car();
                        break;
                    case VehicleTypes.MC:
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}