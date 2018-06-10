using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实现索引器
            var nlist = new NumberList();
            nlist[0] = 1;
            nlist[1] = 2;
            nlist[2] = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nlist[i]);
            }

            // 索引器的重载
            Console.WriteLine(nlist["3"]);

            Console.ReadLine();
        }
    }

    class NumberList
    {
        private int[] nlist = new int[3];

        public NumberList() { }

        // 索引器一
        public int this[int index]
        {
            get
            {
                int temp = 0;
                if (index >= 0 && index < nlist.Length)
                {
                    temp = nlist[index];
                }
                return temp;
            }
            set
            {
                if (index >= 0 && index < nlist.Length)
                {
                    nlist[index] = value;
                }
            }
        }

        // 索引器二
        public int this[string Value]
        {
            get
            {
                int index = 0;
                while (index < nlist.Length)
                {
                    if (nlist[index] == int.Parse(Value))
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }

        }
    }

    public interface ISomeInterface
    {
        int this[int index]
        {
            get;
            set;
        }
    }

    // interface 的具体实现
    public class IndexClass : ISomeInterface
    {
        private int[] nlist = new int[100];
        public int this[int index]
        {
            get { return nlist[index]; }
            //private set { nlist[index] = value; } //不能对接口或显式接口成员实现使用访问器修饰符。
            set { nlist[index] = value; }
        }
    }
}
