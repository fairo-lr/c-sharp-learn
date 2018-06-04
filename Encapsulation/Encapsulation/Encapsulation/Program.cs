using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtherNamespace;
using AnotherAssembly;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // public , private , internal, protected , internal protectd

            //public
            Person p = new Person();
            p.GetAge();

            //private
            //p.age;

            // internal 在 assbemly中都可以使用
            // 注意assbemly 和 namespace 的区别
            AnotherNamespaceClass other = new AnotherNamespaceClass();//另一个命名空间的使用

            Class1 anotherA = new Class1();//另一个程序集
            Console.Write(other.internalStr); //internal,.本程序集可以访问

            Man man = new Man();
            Console.Write(man.GetPerSonName());//protect

            //internal protect, 其他assembly 继承本assembly某些字段, 也可以访问

            Console.ReadLine();
        }
    }

    class Person {
        private int age;
        protected string name = "PersonName";
        //定义属性
        public int Age { get; set; }
        public int GetAge()
        {
            if (CheckAge())
            {
                return age;
            }
            return -1;
        }

        //使用private方法, 主要用于一些不用暴露给外部使用的方法, 一般只是自己内部使用.
        private bool CheckAge()
        {
            if (age <= 0)
            {
                return false;
            }
            return true;
        }
    }

    class Man : Person {
        public string GetPerSonName()
        {
            return base.name;
        }
    }
}
