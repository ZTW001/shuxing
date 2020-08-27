using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shuxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object myObj...");
            Myclass myObj = new Myclass("My Object");
            Console.WriteLine("myObj created.");
            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine("\nAttempting to assign {0} to myObj.Val...", i);
                    myObj.Val = i;
                    Console.WriteLine("Value {0} assigned to myObj.Val.", myObj.Val);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception {0} thrown.", e.GetType().FullName);
                    Console.WriteLine("Message:\n\"{0}\"",e.Message);
        }
    }
        Console.WriteLine("\nOutputting myObj.ToString()...");
        Console.WriteLine(myObj.ToString());
        Console.WriteLine("MyObj.ToString() Output.");
        Console.ReadKey();
        }
    }
 }