using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VYL01102015
{
    class Test
    {
        static void Main(string[] args)
        {
            //Rasyonel r = new Rasyonel(10,24);
            //Console.WriteLine(r.goruntule());
            //Rasyonel r1 = new Rasyonel(5,4);
            //Console.WriteLine(r1.goruntule());
            //Rasyonel r2=r.topla(r1);
            //Console.WriteLine(r2.goruntule());
            //Console.WriteLine(r.goruntule()+"+"+r1.goruntule()+"="+r2.goruntule());

            //Rasyonel r3 = r.bolme(r1);
            //Console.WriteLine(r.goruntule() + "/" + r1.goruntule() + "=" + r3.goruntule());
            //Rasyonel r4 = r1.bolme(r);
            //Console.WriteLine(r1.goruntule() + "/" + r.goruntule() + "=" + r4.goruntule());
            //Console.WriteLine(r3.goruntuleFloat());

            int[] sayilar = {3,5,2,1,7,6,2,4};
            DiziIslemleri dIslem = new DiziIslemleri();
            dIslem.diziGoruntule(sayilar);
            dIslem.tersCevir(sayilar);
            Console.WriteLine("ters hali");
            dIslem.diziGoruntule(sayilar);
        
        }
    }
}
