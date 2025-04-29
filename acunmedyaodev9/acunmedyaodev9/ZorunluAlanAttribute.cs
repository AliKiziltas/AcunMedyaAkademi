using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev9
{
    public class ZorunluAlanAttribute : Attribute
    {
        public string HataMesaji { get; set; }

        public ZorunluAlanAttribute(string hataMesaji)
        {
            HataMesaji = hataMesaji;
        }
    }
}
