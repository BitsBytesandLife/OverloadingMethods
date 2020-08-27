using System;
using System.Xml.Schema;

namespace OverloadingMethods
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal depostitOne, decimal depositTwo)
        {
            return depostitOne + depositTwo;
        }

       static string Add(decimal depostitOne, decimal depositTwo, bool didYouBuyAnything)
       {
            if (didYouBuyAnything == true)
            {
                Console.WriteLine($"{depostitOne + depositTwo} dollars");
            }
            
            return "I didn't buy anything";   
       }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Sum of Ints {Add(3,4)}");
            Console.WriteLine($"Dec {Add(3m, 4m)}");
            Add(4m, 5m, true);
        }
    }
}
