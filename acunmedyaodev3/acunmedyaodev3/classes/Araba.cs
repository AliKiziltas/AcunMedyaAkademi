using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev3.classes
{
    public class Araba
    {

        //değişkenler properties
        public string marka = null;
        public string model = null;
        public int kapiSayisi = 0;
        public int pencereSayisi = 0;
        public int caryas;
        public void markaModelYaz(string markasi, string modeli)
        {
            Console.WriteLine(markasi + modeli);
        }
        public int arabaYas(int uretimyili)
        {
            int sonuc = 0;
            sonuc = DateTime.Now.Year - uretimyili;
            return sonuc;
        }
        public string Marka;
        public string Model;
        public double Tuketim; // 100 km'de tüketilen benzin (litre)
        public double Mesafe; // Kat edilen mesafe (km)

        public Araba(string marka, string model, double tuketim, double mesafe)
        {
            Marka = marka;
            Model = model;
            Tuketim = tuketim;
            Mesafe = mesafe;
        }

        public Araba()
        {
        }

        public double ToplamTuketim()
        {
            return (Tuketim * Mesafe) / 100;

        }
    

}
    }

