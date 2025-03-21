using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[5];
        int toplam = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
            {
                Console.Write("Geçersiz giriş! Lütfen " + i + 1 + ".sayıyı tekrar giriniz: ");
            }
        }
        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }
        double ortalama = (double)toplam / sayilar.Length;
        Console.WriteLine("Girilen sayıların toplamı: " + toplam);
        Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
    }
}