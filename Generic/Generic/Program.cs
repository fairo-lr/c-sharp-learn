using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> ma = new MyGenericArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                ma.SetItem(i, i + 1);
            }

            Console.ReadLine();
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

    }
}
