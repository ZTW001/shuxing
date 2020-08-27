using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shuxing
{
    public class Myclass
    {
        public readonly string Name;
        private int intVal;

        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10."));
            }
        }
        public override string ToString()
            {
                return "Name: " + Name + "\nVal: " + Val;
            }
        private Myclass() : this("Default Name")
        {

        }

        public Myclass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
    }
   
}
