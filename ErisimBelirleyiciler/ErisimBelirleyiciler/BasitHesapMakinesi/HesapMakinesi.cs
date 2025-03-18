using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AcunMedyaErisimB.BasitHesapMakinesi
{
    class HesapMakinesi
    {
        public void Hesapla()
        {
            Console.WriteLine("İşlemi Seçiniz(/,*+,-)");
            string islem = Console.ReadLine();
            Console.Write("sayi1: ");
            string sayi1 = Console.ReadLine();
            Console.Write("sayi2: ");
            string sayi2 = Console.ReadLine();
            while (true)
            {
                if (islem == "-")
                {
                    // tryparse int ise hata vermiyo oyksa hata verir
                    int.TryParse(sayi1, out int a);
                }
            }
            

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
        public int Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
