using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    // 1.声明委托
    delegate int NumberChanger(int p);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            // 2.绑定函数
            NumberChanger nc = new NumberChanger(AddNum);
            // 3.调用委托
            nc(25); 
            Console.WriteLine(num);

            // 通过委托调用实例化方法
            MyClass mc = new MyClass();
            NumberChanger mcn = new NumberChanger(mc.AddNum);
            mcn(25);
            Console.WriteLine(mc.num);
            NumberChanger mun = new NumberChanger(mc.MulNum);
            mun(2);
            Console.WriteLine(mc.num); 


            Console.ReadLine(); 
        }

        public static int AddNum(int p)
        {
            num = num + p;
            return num;
        }
    }

    class MyClass
    {
        public int num = 10;
        public int AddNum(int p)
        {
            num = num + p;
            return num;
        }
        public int MulNum(int p)
        {
            num = num * p;
            return num;
        }
    }
}
