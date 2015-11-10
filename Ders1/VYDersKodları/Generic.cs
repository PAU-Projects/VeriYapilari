using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD29092015
{
    class Generic<T> where T :IComparable
    {
        T [] x;


        public Generic(int size)
        {
            x = new T[size];
        }

        public T EnKucuk()
        {
            T kucuk = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i].CompareTo(kucuk)==-1)
                    kucuk = x[i];
            }
            return kucuk;


        }
        public void display()
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
