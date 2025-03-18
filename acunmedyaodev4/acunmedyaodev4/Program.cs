using acunmedyaodev4.classes;
using System.Xml.Schema;
#region Composition
Marka marka = new Marka("X5", 2000000);
Kasa kasa = new Kasa("Sedan");
Pencere pencere = new Pencere(4);
Kapi kapi = new Kapi(4);
Govde govde = new Govde(kapi,pencere,kasa,marka);
Araba yeni = new Araba("BMW",govde);
yeni.ekranaYaz();
#endregion
#region Matematik
Matematik m = new Matematik();
Console.WriteLine("Sayıların toplamı: " + m.Topla(3.2, 5.3, 6.1));
Console.WriteLine("Sayıların toplamı: " + m.Topla(12,56));
int[] sayilar = { 3, 5, 8, 9, 3, 123, 52 };
Console.WriteLine("Sayıların toplamı: " + m.Topla(sayilar));
Console.WriteLine("Sayıların carpımı: " + m.Carp(9, 3));
Console.WriteLine("Sayıların carpımı: " + m.Carp(2.5, 10,1));
#endregion