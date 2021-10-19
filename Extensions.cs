using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 

        public static int GetOptions<T>()where T : System.Enum
        {
            
            var options = new List<int>();

            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                options.Add(item);


            var input = int.Parse( Console.ReadLine());

            if (options.Contains(input))
                return input;
            else
                return GetOptions<T>();

        }
    }
}
