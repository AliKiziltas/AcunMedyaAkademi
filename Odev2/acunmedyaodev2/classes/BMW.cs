using acunmedyaodev2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev2.classes
{
    public class BMW : Araba, IUcmak, IHizli,IYuzer, IYakit
    {
        public void ucar(string marka)
        {
            Console.WriteLine(marka + " havada uçar");
        }
        public void hizli(string marka)
        {
            Console.WriteLine(marka + " çok hızlı gider");
        }
        public void yuzer(string marka)
        {
            Console.WriteLine(marka + " denizde yüzer");
        }
        public double OrtYakit()
        {
            return 80.0;        
        }
    }   
}
