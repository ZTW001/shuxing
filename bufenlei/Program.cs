using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bufenlei
{
    class Program
    {
        public class MyClass
        {
            #region Fields
            private int myInt;
            #endregion

            #region Constructor
            public MyClass()
            {
                myInt = 99;
            }
            #endregion

            #region Properties
            public int MyInt
            {
                get
                {
                    return myInt;
                }
                set
                {
                    myInt = value;
                }
            }
            #endregion

            #region Methods
            public void DoSomething()
            {
                //Do something,,
            }
            #endregion
        }
    }
}
