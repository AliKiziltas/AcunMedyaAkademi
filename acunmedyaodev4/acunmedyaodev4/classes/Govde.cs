using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev4.classes
{
    public class Govde
    {
        public Kapi kapi;
        public Pencere pencere;
        public Kasa kasa;
        public Marka marka;
        public Govde(Kapi kapi, Pencere pencere, Kasa kasa, Marka marka)
        {
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasa = kasa;
            this.marka = marka;
        }
    }
}
