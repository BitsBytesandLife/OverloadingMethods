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
            var message = "I didn't buy anything";
            

            if (didYouBuyAnything)
            {
                Console.WriteLine(didYouBuyAnything);
                
                var total = Add(depostitOne, depositTwo);

                if (total != 1 && didYouBuyAnything == true )
                {
                    message = $"{total} dollars";
                }
                else 
                { 
                    message = $"{total} dollar";
                }
            }

            return message;
             
       }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Sum of Ints {Add(3,4)}");
            Console.WriteLine($"Dec {Add(3m, 4m)}");
            Console.WriteLine(Add(4m, 5m, true));
            Console.WriteLine(Add(4m, 5m, false));
            //Add(4m, 5m, false);
            //Add(0m, 0m, true);
            //Add(0m, 0m, false);
        }
    }
}
