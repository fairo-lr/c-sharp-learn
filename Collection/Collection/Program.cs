using System;
using System.Collections;
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

            // ArrayList & List
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add("jikexueyuan");
            List<int> li = new List<int>();
            li.AddRange(new int[] { 1, 2, 3 });

            // Hashtable & Dictionary
            Hashtable ht = new Hashtable();
            ht.Add(1, 2);
            ht.Add("2", "2");
            Console.WriteLine(ht["2"]);
            Console.WriteLine(ht[1]); 

            Dictionary<string, string> dt = new Dictionary<string, string>();
            //dt.Add(100, 101);
            dt.Add("100", "101");
            Console.WriteLine(dt["100"]);

            //排序使用
            SortedList<int, int> st = new SortedList<int, int>();

            //Stack,Queue

            Console.ReadLine();
        }
    }
}
