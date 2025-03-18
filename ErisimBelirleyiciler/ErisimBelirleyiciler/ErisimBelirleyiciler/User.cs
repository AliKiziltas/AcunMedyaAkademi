using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunMedyaErisimB.ErisimBelirleyiciler
{
    public class User
    {
		private string adSoyad;

		public string AdSoyad
		{
			get { return adSoyad; }
			set { adSoyad = value; }
		}
		private int yas;

		public int Yas
		{
			get { return yas; }
			set { yas = value; }
		}

        public string Email { get; set; }

		public void BilgileriGoster()
		{
            Console.WriteLine("Ad: " + adSoyad + " Yas: " + yas);
		}
    }
}
