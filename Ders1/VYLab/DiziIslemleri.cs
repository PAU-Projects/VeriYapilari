using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VYL01102015
{
    class DiziIslemleri
    {
        public void diziGoruntule(int[] dizi)
        {
            foreach ( int item in dizi)
            {
                Console.WriteLine(item);
                
            }
        }
        public void tersCevir(int[] dizi)
        {
            int gecici;
            for (int i = 0; i  < dizi.Length/2; i++)
            {
                gecici = dizi[i];
                dizi[i] = dizi[dizi.Length - 1 - i];
                dizi[dizi.Length - 1 - i] = gecici;
            }
        }
    }
}
