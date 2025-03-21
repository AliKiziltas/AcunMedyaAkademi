using System;

class Program
{
    static void Main(string[] args)
    {
        int sayi1, sayi2;
        string islem;

        Console.Write("1. sayıyı giriniz: ");
        while (!int.TryParse(Console.ReadLine(), out sayi1))
        {
            Console.Write("Geçersiz giriş! Lütfen bir sayı giriniz: ");
        }

        
        Console.Write("Yapacağınız işlemi belirtin (+, -, *, /): ");
        while (true)
        {
            islem = Console.ReadLine();
            if (islem == "+" || islem == "-" || islem == "*" || islem == "/")
            {
                break; 
            }
            Console.Write("Geçersiz işlem! Lütfen sadece +, -, *, / giriniz: ");
        }
        Console.Write("2. sayıyı giriniz: ");
        while (!int.TryParse(Console.ReadLine(), out sayi2))
        {
            Console.Write("Geçersiz giriş! Lütfen bir sayı giriniz: ");
        }

        
        while (islem == "/" && sayi2 == 0)
        {
            Console.WriteLine("Bölen sayı 0 olamaz.");
            Console.Write("Lütfen geçerli bir sayı giriniz: ");
            while (!int.TryParse(Console.ReadLine(), out sayi2))
            {
                Console.Write("Geçersiz giriş! Lütfen bir sayı giriniz: ");
            }
        }

        
        if (islem == "*")
        {
            Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
        }
        else if (islem == "-")
        {
            Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
        }
        else if (islem == "+")
        {
            Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
        }
        else if (islem == "/")
        {
            Console.WriteLine($"Sonuç: {sayi1 / (double)sayi2}");
        }
    }
}
