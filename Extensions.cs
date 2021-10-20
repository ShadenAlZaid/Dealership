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
 
        public static int GetSelectedOptions<T>()where T : System.Enum
        {
            
            var options = new List<int>();

            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                options.Add(item);

            var input = Console.ReadLine();
            bool v = int.TryParse(input, out int x);

            // check if parsed input is in enum 
            if (v == true){ //if true return parsed value
                foreach(int z in Enumerable.Range(1,Enum.GetNames(typeof(T)).Length)){
                    if(int.Parse(input) == z){
                        return int.Parse(input);
                    }  
                }
            }else
                Console.Write("Please re-enter your choice! "); 
                return GetSelectedOptions<T>();

        }
        

    }
}
