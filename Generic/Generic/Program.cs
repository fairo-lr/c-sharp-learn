using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    delegate T NumberChanger<T>(T n);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> ma = new MyGenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                ma.SetItem(i, i + 1);
            }

            // 多重泛型
            MyGenericArray<int, string> ma2 = new MyGenericArray<int, string>();

            // 多重带限制的泛型
            MyGenericArray2<int, string> ma3 = new MyGenericArray2<int, string>();

            // 多重带限制的泛型
            //MyGenericArray2<string, string> m3 = new MyGenericArray2<string, string>();

            // 泛型的继承
            SonMyGenericArray<int> sma = new SonMyGenericArray<int>(3);

            // 泛型的继承也可以指定类型
            SonMyGenericArray sma2 = new SonMyGenericArray(3);

            // 泛型在方法上的实现
            // 泛型类 和 泛型方法的数据类型可以不一致
            ma.SetItem<char>(5, 'c');
            ma.SetItem<string>(5, "c");

            // 非泛型类的泛型方法
            int a = 10; int b = 20;
            char c = 'i'; char d = 'u';
            Console.WriteLine("a:{0} b:{1}", a, b);
            Console.WriteLine("c:{0} d:{1}", c, d);
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            Console.WriteLine("a:{0} b:{1}", a, b);
            Console.WriteLine("c:{0} d:{1}", c, d);

            // 泛型在委托中的应用
            NumberChanger<int> n1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> n2 = new NumberChanger<int>(MultNum);
            n1(25);
            n2(5);

            Console.ReadLine();
        }


        private static void Swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }

        public static int num = 10;

        public static int AddNum(int temp)
        {
            num += temp;
            return num;
        }
        public static int MultNum(int temp)
        {
            num *= temp;
            return num;
        }
    }

    class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size];
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
                return default(T);
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
        public void SetItem<X>(int index, X value)
        {
        }

    }

    class MyGenericArray<T, K>
    {
    }

    // 多重带限制的泛型
    // struct 代表必须是值类型, 除此之外还可以是引用类型, class等
    class MyGenericArray2<T, K> where T : struct
    {
    }

    class SonMyGenericArray<T> : MyGenericArray<T>
    {
        private T[] array;

        public SonMyGenericArray(int size) : base(size)
        {
        }
    }
    class SonMyGenericArray : MyGenericArray<int>
    {
        private int[] array;

        public SonMyGenericArray(int size) : base(size)
        {
        }
    }
}