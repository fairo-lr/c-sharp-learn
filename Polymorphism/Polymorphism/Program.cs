using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // 静态多态
            // 方法重载
            PrintHello();
            PrintHello("world");
            // 运算符重载
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            c1.Number = 2;
            c2.Number = 3; 

            Console.WriteLine((c1 + c2).Number);

            //动态多态
            //
            //
            Console.ReadLine();

        }
         
        public static void PrintHello()
        { }

        public static void PrintHello(string toWho)
        { }

        //无法实现返回值不同,参数相同的重载
        //public static string PrintHello()
        //{
        //}
    }

    class Complex
    {
        public int Number { get; set; }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.Number = c1.Number + c2.Number;
            return c;
        }
    }
}
