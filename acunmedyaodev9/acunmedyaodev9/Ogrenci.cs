using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev9
{
    public class Ogrenci
    {
        [ZorunluAlan("Ad boş geçilemez.")]
        public string Ad { get; set; }

        [ZorunluAlan("Soyad boş geçilemez.")]
        public string Soyad { get; set; }

        [ZorunluAlan("Bölüm boş geçilemez.")]
        public string Bolum { get; set; }
    }
}
