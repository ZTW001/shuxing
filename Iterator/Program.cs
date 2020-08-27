using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primeFrom2To1000 = new Primes(2, 100000000);
            foreach (long i in primeFrom2To1000)
                Console.Write(" {0} ", i);
            Console.ReadKey();
        }
    }
}
