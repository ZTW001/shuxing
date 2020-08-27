using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_generic_classes
{
    public class Farm<T> : IEnumerable<T>
       where T : Animal
    {
        private List<T> animals = new List<T>();

        public List<T> Animals
        {
            get
            {
                return animals;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return animals.GetEnumerator();
        }

        public void MakeNoises()
        {
            foreach (T animal in animals)
            {
                animal.MakeANoise();
            }
        }

        public void FeedTheAnimals()
        {
            foreach (T animal in animals)
            {
                animal.Feed();
            }
        }

        public Farm<Cow> GetCows()
        {
            Farm<Cow> cowFarm = new Farm<Cow>();
            foreach (T animal in animals)
            {
                if (animal is Cow)
                {
                    cowFarm.Animals.Add(animal as Cow);
                }
            }
            return cowFarm;
        }

        // For generic methods section.
        //public Farm<U> GetSpecies<U>() where U : T
        //{
        //   Farm<U> speciesFarm = new Farm<U>();
        //   foreach (T animal in animals)
        //   {
        //      if (animal is U)
        //      {
        //         speciesFarm.Animals.Add(animal as U);
        //      }
        //   }
        //   return speciesFarm;
        //}
    }
}
