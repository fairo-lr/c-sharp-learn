using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastingDelegate
{
    delegate void DelNum(int i);
    class Program
    {
        static void Main(string[] args)
        {
            DelNum d1 = new DelNum(C1.M1);
            d1(10);
            Console.WriteLine();

            DelNum d2 = new DelNum(C1.M2);
            d2(20);
            Console.WriteLine();

            DelNum d3 = d1 + d2;
            d3(30);
            Console.WriteLine();

            C1 c = new C1();
            DelNum d4 = new DelNum(c.M3);
            d3 += d4;
            d3(40);
            Console.WriteLine();

            d3 += d1;
            d3(50);
            Console.WriteLine();
            d3 -= d1;
            d3(50);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class C1
    {
        public static void M1(int i)
        {
            Console.WriteLine("M1:" + i.ToString());
        }
        public static void M2(int i)
        {
            Console.WriteLine("M2:" + i.ToString());
        }
        public void M3(int i)
        {
            Console.WriteLine("M3:" + i.ToString());
        }
    }
}
