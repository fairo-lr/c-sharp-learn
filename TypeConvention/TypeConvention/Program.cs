using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            // 隐式转换
            int i = 10;
            long li = i;
            C1 c = new C2();

            // 显式转换
            double d = 10.05;
            int id = (int)d; 
            Console.WriteLine(d is int);
            C1 cc = new C1();
            C2 c2 = cc as C2; //显式转换, 失败则为空

            // 类型转换函数
            d.ToString();
            Convert.ToInt32(d);
            Int32.Parse(d.ToString());
            int temp;
            Int32.TryParse(d.ToString(), out temp);

            // 装箱
            int itoBoxing = 100;
            object iboxed = itoBoxing;

            // 拆箱
            int iunboxing = (int)iboxed;
            // 有点时候要注意会出现null错误
            object nullobj = null;
            int inull = (int)nullobj;

            // 可为空类型
            int? inullable = null;
            System.Nullable<int> inullable2 = 100;
            Console.WriteLine(inullable.HasValue);
            Console.WriteLine(inullable.GetValueOrDefault());

            // ?? 的用法
            int iii = inullable ?? 500;
            Console.ReadLine();
        }
    }
    class C1 { }
    class C2 : C1 { }
}
