// See https://aka.ms/new-console-template for more information
using acunmedyaodev2.classes;
using acunmedyaodev2.Sirket;

Console.WriteLine("Hello, World!");
BMW bm = new BMW();
bm.marka = "BMW";


Mercedes mer = new Mercedes();
mer.marka = "Mercedes";

Porsche pors = new Porsche();
pors.marka = "Porsche";

bm.hizli(bm.marka);
bm.yuzer(bm.marka);
bm.ucar(bm.marka);

mer.yuzer(mer.marka);
mer.ucar(mer.marka);

pors.ucar(pors.marka);

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programcı pr = new Programcı();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam : " + toplamMaas + "TL maaş alıyorlar..");

double toplamYakit = 0.0;
toplamYakit += bm.OrtYakit();
toplamYakit += mer.OrtYakit();
toplamYakit += pors.OrtYakit();
Console.WriteLine("Bir saatte toplam : " + toplamYakit + " litre yakıt yakıyorlar.");

