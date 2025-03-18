using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace acunmedyaodev4.classes
{
    public class Araba
    {
        public string mrk;
        public Govde govde;

        public Araba(string mrk, Govde govde)
        {
            this.mrk = mrk;
            this.govde = govde;
        }

        public void ekranaYaz()
        {
            Console.WriteLine("Arabanın Markası: " + mrk + " modeli: " + govde.marka.model + " kapı sayısı: " + govde.kapi.kapiSayisi + " pencere sayısı: "
                + govde.pencere.pencereSayisi + " fiyatı: " + govde.marka.fiyat);
        }

    }
}
