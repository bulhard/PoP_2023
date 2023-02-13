using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Generics.AnimalShelter
{
    public class AnimalShelter<T>
    {
        private int usedPlaces = 0;

        public AnimalShelter(int capacity)
        {
            Places = new T[capacity];
        }

        public T[] Places { get; set; }

        public void AddNew(T newAnimal)
        {
            Places[usedPlaces] = newAnimal;
            usedPlaces++;
        }
    }
}
