using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            One one = new One();
        }
    }

    class Animal {
        public int Age { get; set; }
        public virtual void Bite()
        {
            Console.WriteLine("Animal Bite");
        }

        public virtual void GetAge()
        {
            Console.WriteLine (Age);
        }

        public void BiteMan()
        {
            Console.WriteLine("Animal Bite Man");
        }
    }

    class Dog:Animal
    {
        public override void Bite()
        {
            Console.Write("Dog Bite");
        }

        public new void BiteMan()
        {
            Console.WriteLine("Dog Bite Man");
        }
    }

    class Human { }
    class Man:Human { }
    class One : Man { }
}
