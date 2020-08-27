using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List_sorting
{
    public class Person : IComparable
    {
        public string Name;
        public int Age;

        public Person(String name,int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            if(obj is Person)
            {
                Person otherPerson = obj as Person;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException("Object to compare to is not a Person object.");
            }
        }
    }
}
