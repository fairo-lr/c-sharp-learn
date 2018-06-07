using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.GetName2();//可以直接调用
            p.GetName();
        }
    }

    class Person : Man, ISuper
    {
        public int GetSuper() { return 0; } //interface的方法必须实现
        public override void GetName() {
            //必须继承, 否则报错
        }
    }
    abstract class Man
    {
        public string name;

        public string GetName2()
        {
            return name;
        }

        public abstract void GetName();
    }
    interface ISuper
    {
        int GetSuper();
    }

}
