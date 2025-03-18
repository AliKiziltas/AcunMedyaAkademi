using AcunMedyaErisimB.ErisimBelirleyiciler;
using MyNamespace;
#region ErisimBelirleyiciler
User user = new();
user.AdSoyad = ("Muhammet Ali Kızıltaş");
user.Yas = 21;
user.Email = "alikiziltas477@gmail.com";
user.BilgileriGoster();
#endregion
#region Namespace
Hesaplama hesaplama = new Hesaplama();
hesaplama.Topla(3, 5);
hesaplama.Carp(3, 5);
#endregion
#region MerhabaDünya
Console.WriteLine("Merhaba Dünya!");
#endregion
