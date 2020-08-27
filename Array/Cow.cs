using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    public class Cow : Animal
    {
        public void milk()
        {
            Console.WriteLine("{0} has been milked.", name);
        }
        public Cow(string newName) : base(newName)
        {

        }
    }
}
