using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev3.classes
{
    public class Calisan
    {
        public string ad;
        public string soyad;
        public int maas;
        public string departman;

        public Calisan(string a, string s, int m, string d)
        {
            ad = a;
            soyad = s;
            maas = m;
            departman = d;
        }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine($"{ad} {soyad} - {departman} - Maaş: {maas} TL");
        }

        public int MaasDondur()
        {
            return maas;
        }

    }
}
