using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //一维数组初始化
            int[] number = new int[5] { 1,2,3,4,5};
            int[] number2 = new int[] { 1,2,3,4,5 };
            int[] number3 =   { 1,2,3, 4,5 };

            //二维数组初始化
            string[,] str = new string[2, 2] { { "1", "2" }, { "3", "4" } };
            string[,] str2 = { { "1", "2" }, { "3", "4" } };

            //多维数组初始化
            byte[][] ss = new byte[5][];
            int[][] ss2 = { new int[] { 1, 2 }, new int[] { 1,2,3} };

            for (int i = 0; i < ss.Length; i++)
            {
                //初始化长度不固定
                ss[i] = new byte[i + 3];
            }

            Console.ReadLine();
        }
    }
}
