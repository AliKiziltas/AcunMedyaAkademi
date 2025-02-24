// See https://aka.ms/new-console-template for more information
using acunmedyaodev1.classes;

Console.WriteLine("Hello, World!");
Bmw bm = new Bmw();
bm.marka = "Bmw";
bm.vites = "Düz";
bm.vites_durumu(bm.marka, bm.vites);

Porsche ph = new Porsche();
ph.marka = "Porsche";
ph.vites = "Otomatik";
ph.vites_durumu(ph.marka, ph.vites);

Togg tg = new Togg();
tg.marka = "Togg";
tg.vites = "Otamatik";
tg.vites_durumu(tg.marka, tg.vites);

Mercedes mr = new Mercedes();
mr.marka = "Mercedes";
mr.vites = "Düz";
mr.vites_durumu(mr.marka, mr.vites);

Toyota tyt = new Toyota();
tyt.marka = "Toyota";
tyt.vites = "Düz";
tyt.vites_durumu(tyt.marka, tyt.vites);

Audi au = new Audi();
au.marka = "Audi";
au.vites = "Otomatik";
au.vites_durumu(au.marka, au.vites);