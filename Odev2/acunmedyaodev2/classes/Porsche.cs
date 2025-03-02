using acunmedyaodev2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev2.classes
{
    class Porsche : Araba, IUcmak, IYakit
    {
        public void ucar(string marka)
        {
            Console.WriteLine(marka + " havada uçar");
        }
        public double OrtYakit()
        {
            return 60.0;
        }
    }
}
