using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev1.classes
{
    public class Araba
    {
        public string marka = null;
        public string model = null;
        public string vites = null;
        public int kapisayisi = 0;
        public int penceresayisi = 0;
        public void vites_durumu(string markasi, string vitesi)
        {
            Console.WriteLine(markasi + " " + vitesi + " viteslidir.");
        }
    }
}
