using acunmedyaodev2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev2.classes
{
    class Mercedes : Araba, IYuzer, IUcmak, IYakit
    {
        public void yuzer(string marka)
        {
            Console.WriteLine(marka + " denizde yüzer");
        }
        public void ucar(string marka)
        {
            Console.WriteLine(marka + " havada uçar");
        }
        public double OrtYakit()
        {
            return 70.0;
        }
    }
}
