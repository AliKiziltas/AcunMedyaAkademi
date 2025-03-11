using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev3.classes
{
    public class Insan
    {
        
          
            public string adi = null;
            public string soyadi = null;
            public int yas;
            public double maas = 3.14;
            public bool cinsiyet;
        
            public int yasHesapla(int DogumYili)
            {
                int sonuc = 0;
                sonuc = DateTime.Now.Year - DogumYili;
                return sonuc;
            }


        }  //bitiş 

    }

