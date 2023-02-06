using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals 
{
    public class Dog
    {
        public static int Count = 0;

        public Dog()
        {
            name = "";
            Count++;
        }

        public Dog(int age, string name)
        {
            Age = age;
            this.name = name;
            Count++;
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }

        public int Age { get; }

        public void Bark()
        {
            Console.WriteLine($"Woff, Woff, I am {name} ");
        }
    }
}
