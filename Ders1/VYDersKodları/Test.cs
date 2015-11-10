using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD29092015
{
    class Test
    {
        int a;//field, class variable

        public void display()
        {
            //Console.WriteLine(x);out of scope
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            //int x=6;//variable değişken
            ////Console.WriteLine(x);
            ////Test testObj = new Test();
            ////Console.WriteLine(testObj.a);
            MyFirstClass obj1 = new MyFirstClass();
            //MyFirstClass obj2 = new MyFirstClass(2, 3);
            //obj2.Display();
            //obj1.Display();
            ////int sonuc=obj1.Topla();
            //int sonuc = obj1.Topla(3, x);
            //Console.WriteLine(x);//6 
            //sonuc = obj1.Topla(2, obj2);//5
            //Console.WriteLine(obj2.y);//3 or 11?
            //double y=5.4;
            //y = x;
            //x = (int)y;
            ////Test t1 = (Test)obj2;classlararası ilişki yok
            //Object o = (object)obj1;
            //int[] sayilar = new int[5];
            //sayilar[0] = 8;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //int[] numbers = { 2, 5, 7 };
            //numbers = sayilar;

            //Console.WriteLine("en kucuk"+obj1.EnKucuk(numbers));
            Generic<int> g1 = new Generic<int>(5);
            g1.display();
            Generic<string> g2 = new Generic<string>(3);
            g2.display();
            Generic<MyFirstClass> g3 = new Generic<MyFirstClass>(5);
            Stack<string> stack = new Stack<string>();
            stack.Push("Ankara");
            stack.Push("İstanbul");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();

        }
    }
}
