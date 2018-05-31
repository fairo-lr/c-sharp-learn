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
            // Linq 中的使用
            // nums 可以使用OrderBy直接排序
            // 类似语法糖的概念
            int[] nums = { 10,6,54,12,33,7,11,42};
            var sort = nums.OrderBy(g => g);
            
            // 枚举和方法中的使用
            var g1 = Grades.D;
            var g2 = Grades.A;
            Console.Write(g1.Passing());
            Console.Write(g2.Passing());

            Extention.minPass = Grades.C;//还可以设置之后再使用

            Console.Write(g1.Passing());
            Console.Write(g2.Passing("形参"));

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

        //扩展方法也可以添加形参, 用法和普通函数的一样.
        public static bool Passing(this Grades grade,string param)
        {
            return grade >= minPass;
        }


    }
}
