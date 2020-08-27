using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Defining_events
{
   public class Display
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message arrived: {0}", message);
        }
    }
}
