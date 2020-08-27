using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises07
{
    class Program
    {
        static void Main(string[] args)
        {
             imagNum coord, temp;
            double realTemp2, arg;
            int iterations;
            for(coord.imag = 1.2;coord.imag >= -1.2;coord.imag -= 0.05)
            {
                for(coord.real = -0.6;coord.real <= 1.77;coord.real += 0.03)
                {
                    iterations = 0;
                    temp.real = coord.real;
                    temp.imag = coord.imag;
                    arg = (coord.real * coord.real) + (coord.imag * coord.imag);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (temp.real * temp.real) - (temp.imag * temp.imag) - coord.real;
                        temp.imag = (2 * temp.real * temp.imag) - coord.imag;
                        temp.real = realTemp2;
                        arg = (temp.real * temp.real) + (temp.imag * temp.imag);
                        iterations += 1;
                    }
                    switch(iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("0");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;

                    }
                }
                Console.Write("\n");
            }
        }
    }
}
