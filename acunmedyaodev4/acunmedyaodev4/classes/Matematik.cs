using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev4.classes
{
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public double Topla(double sayi1, double sayi2, double sayi3)
        {
            double sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }
        public int Topla(int[]sayilar)
        {
            int sayiTopla = 0;
            for(int i = 0; i< sayilar.Length; i++)
            {
                sayiTopla = sayiTopla + sayilar[i];
            }
            return sayiTopla;
        }

        public int Carp(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public double Carp(double sayi1, double sayi2,double sayi3)
        {
            double sonuc = 0;
            sonuc = sayi1 * sayi2 * sayi3;
            return sonuc;
        }
    }
}
