using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD29092015
{
    class MyFirstClass:IComparable
    {
        public int x, y;
        public MyFirstClass()//default constructor
        {
            x = 5;
        }
        public MyFirstClass(int a, int y)
        {
            x = a;
            this.y = y;//this means field y
        }
        public int Topla()
        {
            return x+y;
        }
        public int Topla(int a, int x)
        {
            x = 9;
            return a + x;
        }
        public int Topla(int a, MyFirstClass obj)
        {
            obj.y = 11;
            return a + obj.y;
        }
        public void Display()
        {
            Console.WriteLine(x+" "+y);
        }
        public int EnKucuk(int [] numbers)
        {
            int kucuk = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < kucuk)
                    kucuk = numbers[i];
            }
            return kucuk;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
