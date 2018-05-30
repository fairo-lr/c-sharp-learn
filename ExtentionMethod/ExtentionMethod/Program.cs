using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    public enum Grades { F = 0, E = 1, D = 2, C = 3, B = 4, A = 5 };
    class Program
    {
        static void Main(string[] args)
        {
            Grades g1 = Grades.D;
            Grades g2 = Grades.A;
            Console.Write(g1.Passing());
            Console.Write(g2.Passing());

            Extention.minPass = Grades.C;

            Console.Write(g1.Passing());
            Console.Write(g2.Passing());

            Console.ReadLine();
        }
    }

    //扩展方法
    public static class Extention
    {
        public static Grades minPass = Grades.E;
        public static bool Passing(this Grades grade)
        {
            return grade >= minPass;
        }

    }
}
