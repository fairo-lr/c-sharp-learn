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
            //One one = new One();
            Dog dog = new Dog();
            dog.Age = 10;
            dog.Bite();
            dog.GetAge();
            dog.BiteMan();
            //构造实例化: 先调用父类构造函数,在调用子类的构造函数

            Dog dog2 = new Dog(10);
            //默认先调用父类的默认构造函数, 在调用子类的特定构造函数

            Animal dog3= new Dog();
            dog3.Bite();//调用子类

            dog3.BiteMan();//调用父类
            ((Dog)dog3).BiteMan();//调用父类

            Console.ReadLine();
        }
    }

    class Animal
    {
        public Animal() { Console.WriteLine("Animal constructor"); }
        public Animal(int age) { Console.WriteLine("Animal(int)  constructor"); }
        public int Age { get; set; }
        public virtual void Bite()
        {
            Console.WriteLine("Animal Bite");
        }

        public virtual void GetAge()
        {
            Console.WriteLine(Age);
        }

        public void BiteMan()
        {
            Console.WriteLine("Animal Bite Man");
        }
    }

    sealed class Dog : Animal
    {
        public Dog() { Console.WriteLine("Dog constructor"); }
        //如果设置此构造函数, 则会调用父类的特定构造函数, 在调用子类的特定构造函数
        //public Dog(int age):base(age) { Console.WriteLine("Dog(int)  constructor"); }

        //如果设置此构造函数, 则会调用父类的默认构造函数,  在调用子类的默认构造函数, 在调用子类的特定构造函数
        //public Dog(int age):this() { Console.WriteLine("Dog(int)  constructor"); }

        public Dog(int age) { Console.WriteLine("Dog(int)  constructor"); }

        public override void Bite()
        {
            Console.WriteLine("Dog Bite");
        }

        public new void BiteMan()
        {
            Console.WriteLine("Dog Bite Man");
        }
    }

    //class LittleDog : Dog { }
    class Human { }
    class Man : Human { }
    class One : Man { }
}
