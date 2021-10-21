using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Vehicle;

namespace Dealership
{
    public  class Extensions
    {
        
        public static void PrintEnum(Type x)
        {
            foreach (int i in Enum.GetValues(x))
            {
                Console.WriteLine($"{i}. {Enum.GetName(x, i)}");
            }
        }
 

        public static int GetSelectedOptions<T>()where T : System.Enum
        {
            
            var options = new List<int>();

            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                options.Add(item);

            Console.Write("Enter you choice number: ");            
            var input = Console.ReadLine();

            // check if parsed input is in enum 
            if (int.TryParse(input, out int x)){ //if true return parsed value
                foreach(int z in Enumerable.Range(1, Enum.GetNames(typeof(T)).Length))
                {
                    if(x == z)
                    {
                        return x;
                    }  
                }
            }
            Console.Write("Please re-enter your choice! "); 
            return GetSelectedOptions<T>();
        }


        public static void GetMenu(){
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
