using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. query syntax
            int[] number = {5,10,9,8,3,6,12 };
            var nums = from num in number
                       where num % 2 == 0
                       orderby num
                       select num;
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }

            //2. method syntax
            var nums2 = number.Where(n => n % 2 == 0).OrderBy(n => n);
            nums2.Count();
            nums2.ToList();
            nums2.ToArray();
            foreach (var item in nums2)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();

            //3. query syntax 的操作
            // group by 使用
            List<Customer> cs = new List<Customer>();
            var querycs = from c in cs
                          group c by c.City;

            // join in 使用
            List<Customer> cs2 = new List<Customer>();
            List<Employee> ep = new List<Employee>();

            var querycp = from c in cs2
                          join e in ep on c.Name equals e.Name
                          select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

            // into 使用
            List<Customer> cs3 = new List<Customer>();
            var querycs2 = from c in cs3
                           group c by c.City into cgroup
                           where cgroup.Count() == 2
                           select new { City = cgroup.Key, Count = cgroup.Count() };

            // let 使用 
            // let 作用: 临时变量
            // 把string内的字符串全部转换为大写, 个人感觉类似sql中字段的操作函数,比如convert,isnull等
            string[] strings = { "Hello jikexueyuan", "This is Friday!", "Are you Happy?" };
            var strQuery = from str in strings
                           let words = str.Split(' ')
                           from word in words
                           let w = word.ToUpper()
                           select w;
        }
    }

    class Customer {
        public string Name { get; set; }
        public string City { get; set; }
    }

    class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
