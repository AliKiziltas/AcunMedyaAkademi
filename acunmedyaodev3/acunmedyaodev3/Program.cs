// See https://aka.ms/new-console-template for more information
using acunmedyaodev3.classes;
using System.Collections;
using System.Threading.Channels;

Console.WriteLine("Hello, World!");
Cocuk co = new Cocuk();
co.adi = "berk";
co.soyadi = "kerim";
Console.Write("Doğum yılını giriniz : ");
int gelenYas = co.yasHesapla(co.yas = Convert.ToInt16(Console.ReadLine()));


if (gelenYas > 0 && gelenYas <= 18)
{
    Console.WriteLine("Küçüksünüz");
}
else if (gelenYas > 18  && gelenYas <=35)
{
    Console.WriteLine("Gençsiniz");
}
else if (gelenYas > 35 && gelenYas <= 55)
{
    Console.WriteLine("Yetişkinsiniz");
}
else if (gelenYas > 55 && gelenYas <= 75)
{
    Console.WriteLine("Yaşlısınız");
}
else if (gelenYas > 75 && gelenYas <= 99)
{
    Console.WriteLine("Çok yaşlısınız");
}
else
{
    Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz...");
}
Araba car = new Araba();
Console.Write("Arabanızın üretim yılını giriniz : ");
int gelenYass = car.arabaYas(car.caryas = Convert.ToInt16(Console.ReadLine()));

if (gelenYass > 0 && gelenYass <= 10)
{
    Console.WriteLine("Arabanız yeni");
}
else if (gelenYass > 10 && gelenYass <= 20)
{
    Console.WriteLine("Servise götürmeniz gerekebilir");
}
else if (gelenYass > 20 && gelenYass <= 30)
{
    Console.WriteLine("Arabanız hurdaya çıkabilir");
}
else
{
    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
}

ArrayList calisanlar = new ArrayList();

calisanlar.Add(new GenelMudur("Ali", "Kerim", 50000));
calisanlar.Add(new Mudur("Buse", "Demir", 30000));
calisanlar.Add(new Programci("Mehmet", "Çetin", 20000));
calisanlar.Add(new Stajyer("Zeynep", "Demir", 5000));

int toplamMaas = 0;
foreach (Calisan calisan in calisanlar)
{
    calisan.BilgileriGoster();
    toplamMaas += calisan.MaasDondur();
}

Console.WriteLine($"Toplam maaş gideri: {toplamMaas} TL");

static string Calistir()
{
    List<Araba> arabalar = new List<Araba>
        {
            new Araba("Toyota", "Corolla", 6.5, 500),
            new Araba("Ford", "Focus", 7.2, 300),
            new Araba("Honda", "Civic", 6.8, 400)
        };

    double toplamBenzin = 0;
    foreach (Araba araba in arabalar)
    {
        toplamBenzin += araba.ToplamTuketim();
    }

    return "Toplam benzin tüketimi: {toplamBenzin:F2} litre";
}
int sayi = 1;
while (sayi <= 5)
{
    Console.WriteLine($"While döngüsü: {sayi}");
    sayi++;
}
int sayi2 = 1;
do
{
    Console.WriteLine($"Do-While döngüsü: {sayi2}");
    sayi2++;
} while (sayi2 <= 5);

