using System;

namespace Regex
{
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            // 使用C#自带的正则表达式
            var s1 = "123";
            var param = "123";
            Console.WriteLine(Regex.IsMatch(s1, param));

            Console.ReadLine();

        }
    }
}
