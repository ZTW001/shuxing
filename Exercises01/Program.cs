using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numbersOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            while(!numbersOK)
            {
                Console.WriteLine("Give me a number:");
                var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Give me another number:");
                var2 = Convert.ToDouble(Console.ReadLine());
                if((var1 > 10) && (var2 > 10))
                {
                    Console.WriteLine("Only one number may be greater than 10.");
                }
                else
                {
                    numbersOK = true;
                }
            }
            Console.WriteLine("You entered {0} and {1}.", var1, var2);
        }
    }
}
