using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化器实现方法
            var student1 = new StudentName("Meimei", "Wang");//调用的是构造函数是public StudentName(string first,string last) 
            var student4 = new StudentName("Meimei", "Wang") { ID = 101 };//调用的是构造函数是public StudentName(string first,string last) 
            var student2 = new StudentName() { FirstName = "Meimei", LastName = "Wang", ID = 101 };//调用的是构造函数是public StudentName() 
            var student3 = new StudentName { FirstName = "Meimei", LastName = "Wang", ID = 101 };//调用的是构造函数是public StudentName() 

            // 匿名类的初始化器
            // 匿名类的属性是只读的
            var pet = new { Age = 10, Name = "Meimei" };
            string name = pet.Name;
            //pet.Name = "无法更改";

            // 匿名类初始化器常用于Linq语句
            List<StudentName> slist = new List<StudentName>();
            var query = from n in slist
                        select new { FirstName = n.FirstName, LastName = n.LastName, Id = n.ID };

            // 集合初始化器
            var students = new List<StudentName>()
            {
                new StudentName("Meimei", "Wang"),
                new StudentName("Meimei", "Wang") { ID = 101 },
                new StudentName() { FirstName = "Meimei", LastName = "Wang", ID = 101 },
                new StudentName { FirstName = "Meimei", LastName = "Wang", ID = 101 },
                null //还可以包含null
            };

            Dictionary<int, StudentName> studentsDic = new Dictionary<int, StudentName>()
            {
                { 101,new StudentName("Meimei", "Wang")},
                { 102,new StudentName("Meimei", "Wang") { ID = 101 }},
                { 103,new StudentName() { FirstName = "Meimei", LastName = "Wang", ID = 101 }},
                { 104, new StudentName { FirstName = "Meimei", LastName = "Wang", ID = 101 }}
            };

            foreach (var item in studentsDic)
            {
                // item.Value就是一个StudentName对象
                Console.Write(item.Value);
            }
        }
    }
    public class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public StudentName() { }
        public StudentName(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
    }
}