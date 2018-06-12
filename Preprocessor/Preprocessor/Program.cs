#define debug
//#undef debug
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preprocessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 收缩预处理指令
            #region
            #endregion

            // 条件预处理指令
#if (debug)
            Console.WriteLine("if debug");


#else
              Console.WriteLine("else debug"); 

#endif

#pragma warning
#pragma checksum "filename" "{guid}" "check bytes"

            // warning 强制抛出警告 
#warning   debug is defind

#line 200 "special" //强制设置行数, special 是修改的文件名
#line default //修改回默认值
            // error 强制抛出警告 
#error debug is error 

            Console.ReadLine();
        }
    }
}
