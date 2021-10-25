using DealershipLibrary.Vehicle;
using DealershipLibrary.Vehicle.Cars;

namespace DealershipLibrary
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
            Console.Write("Please re-enter your choice! \n"); 
            return GetSelectedOptions<T>();
        }

        }
    }

//var options = new List<int>();

//var values = Enum.GetValues(typeof(T));

//foreach (int item in values)
//    options.Add(item);

