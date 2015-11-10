using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VYL01102015
{
    class Rasyonel
    {
        int pay, payda;
        public Rasyonel(int pay,int payda)
        {
            this.pay = pay;
            this.payda = payda;
            int eb = ebob();
            this.pay = this.pay / eb;
            this.payda = this.payda / eb;
        }
        public Rasyonel()
        {
            pay = 1;
            payda = 1;
        }

        /// <summary>
        /// Ebob hesaplar.
        /// </summary>
        /// <returns>Ebob degerini dondurur.</returns>
        private int ebob()
        {
            int a = pay;
            int b = payda;
            int c;//gecici degisken

            if (a < b)
            {
                c = a;
                a = b;
                b = c;
            }

            while (b!=0)
            {
                c = a % b;
                a = b;
                b = c;
                
            }
            return a;
        }
        public string goruntule()
        {
            return "("+pay + "/" + payda+")";
        }
        public Rasyonel topla(Rasyonel r)
        {
            return new Rasyonel(pay*r.payda+r.pay*payda,
                payda*r.payda);

        }
        public Rasyonel cikarma(Rasyonel r)
        {
            return new Rasyonel(pay * r.payda - r.pay * payda,
                payda * r.payda);

        }
        public Rasyonel carpma(Rasyonel r)
        {
            return new Rasyonel(pay * r.pay ,
                payda * r.payda);
        }
        public Rasyonel bolme(Rasyonel r)
        {
            return new Rasyonel(pay * r.payda,
                payda * r.pay);

        }
        public string goruntuleFloat()
        {
            return  "(" + (float)pay / payda + ")";
        }

    }
}
