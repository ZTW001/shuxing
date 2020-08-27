using System;
using System.Collections;

namespace Exercises05
{
    class Program
    {
        public class People:DictionaryBase
        {
            public void Add(People newPerson)
            {
                Dictionary.Add(newPerson.Name, newPerson);
            }
            public void Remove(string name)
            {
                Dictionary.Remove(name);
            }
            public Person this[string name]
            {
                get
                {
                    return (Person)Dictionary[name];
                }
                set
                {
                    Dictionary[name] = value;
                }
            }
        }
    }
}
