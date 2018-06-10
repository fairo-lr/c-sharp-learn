using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event2
{
    class Program
    {
        static void Main(string[] args)
        {
            EventTest e = new EventTest(5);

            // 如果不设置事件绑定函数, 则就会导致触发事件后没有后续动作
            e.ChangeNum += new EventTest.TestHandler(EventTest.NumHasChanged);
            e.SetValue(5);//数字不变, 不触发事件
            e.SetValue(10);//数字变化, 触发事件

            // interface

            I c = new C2(); //使用了多态
            c.mEvent += f;// 正规写法: c.mEvent += new MyDelegate(f);
            c.FireAway();

            Console.ReadLine();
        }
         
        private static void f() {
            Console.WriteLine("event handle");
        }
    } 

    class EventTest
    {
        private int value;
        public delegate void TestHandler();
        public event TestHandler ChangeNum;

        public EventTest(int i) {
            SetValue(i);
        }

        // 设置事件触发的处理函数
        public static void NumHasChanged() {
            Console.WriteLine("Number has changed");
        }

        //设置触发事件的函数
        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }

        public void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();//触发事件
            }
            else
            {
                // 事件为空, 即事件还未被绑定
                Console.WriteLine("Event fired");
            }
        }

    }

    public delegate void MyDelegate();

    interface I {
        event MyDelegate mEvent;
        event EventHandler ehEvent;// 使用EventHandler来实现
        void FireAway();
    }

    class C2 : I
    {
        public event MyDelegate mEvent;
        public event EventHandler ehEvent;  

        public void FireAway()
        {
            if (mEvent != null)
            {
                mEvent();
            }
            if (ehEvent != null)
            {
                //ehEvent(object s, e);
            }
        }
    }

}
