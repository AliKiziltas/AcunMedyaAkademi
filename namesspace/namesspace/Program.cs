using System;

namespace MatematikIslemleri
{
    public class Hesaplama
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
namespace ProgramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MatematikIslemleri.Hesaplama hesap = new MatematikIslemleri.Hesaplama();
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplamSonucu = hesap.Topla(sayi1, sayi2);
            int carpmaSonucu = hesap.Carp(sayi1, sayi2);
            Console.WriteLine($"\nToplam: {toplamSonucu}");
            Console.WriteLine($"Çarpım: {carpmaSonucu}");
        }
    }
}
