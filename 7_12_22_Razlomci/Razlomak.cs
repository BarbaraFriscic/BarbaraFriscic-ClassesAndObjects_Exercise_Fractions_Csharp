using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_12_22_Razlomci
{
    internal class Razlomak
    {
		private int nazivnik;

		public int CijeliBroj { get; set; }
		public int Brojnik { get; set; }
		public int Nazivnik
		{
			get { return nazivnik; }
			set
			{
				if (value == 0)
					nazivnik = 1;
				else
					nazivnik = value;
			}
		}

		public Razlomak(int cijeliBroj, int brojnik, int nazivnik)
		{
			CijeliBroj = cijeliBroj;
			Brojnik = brojnik;
			Nazivnik = nazivnik;
		}
        public Razlomak(int brojnik, int nazivnik):this(0, brojnik, nazivnik)
        {
        }
        public Razlomak():this(0,0,1)
        {
        }

		public void Skrati()
		{
			if(Brojnik >= Nazivnik)
			{
				CijeliBroj += Brojnik / Nazivnik;
				Brojnik = Brojnik % Nazivnik;
			}
		}

		public static Razlomak operator + (Razlomak r1, Razlomak r2)
		{
			int brojnik3;
			int nazivnik3;
			
                r1.Brojnik = (r1.CijeliBroj * r1.Nazivnik) + r1.Brojnik;
				r2.Brojnik = (r2.CijeliBroj * r2.Nazivnik) + r2.Brojnik;

				nazivnik3 = r1.Nazivnik * r2.Nazivnik;
				r1.Brojnik = r1.Brojnik * r2.Nazivnik;
				r2.Brojnik = r2.Brojnik * r1.Nazivnik;
				brojnik3 = r1.Brojnik + r2.Brojnik;

			Razlomak r3 = new Razlomak(brojnik3, nazivnik3);		
			r3.Skrati();
            return r3;
		}
    }
}
