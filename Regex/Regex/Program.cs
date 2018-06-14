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

            string[] values = {"111-22-3333", "111-2-3333" };
            string parttern = @"^\d{3}-\d{2}-\d{4}$";
            foreach (var item in values)
            {
                if (Regex.IsMatch(item,parttern))
                {
                    Console.WriteLine("{0} is valid",item);
                }
                else
                {
                    Console.WriteLine("{0} is not valid", item);
                }
            }

            RegexMatch();
            RegexReplace();
            RegexSplit();
            Console.ReadLine();
          

        }
        //查询
        private static void RegexMatch()
        {
            var input = "This is jikexueyuan jikexueyuan";
            // \1表示重复项
            var pattern = @"\b(\w+)\W(\1)\b";
            Match match = Regex.Match(input, pattern);
            while (match.Success)
            {
                Console.WriteLine(match.Groups[0].Value);
                match = match.NextMatch();
            }
        }

        //替换
        private static void RegexReplace()
        {
            var pattern = @"\b\d+.\d{2}\b";
            // $$表示 $&表示
            string replacement = "$$$&";
            var temp = Regex.Replace("cost:123.35", pattern, replacement);
            Console.WriteLine(temp);
        }

        //分割
        private static void RegexSplit()
        { 
            var input = "1. Egg 2. Bread 3. Milk 4. Coffee";
            string pattern = @"\b\d{1,2}\.\s";
            foreach (string item in Regex.Split(input,pattern))
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
