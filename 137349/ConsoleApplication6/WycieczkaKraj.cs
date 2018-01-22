using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class WycieczkaKraj : Wycieczka
    {
        private bool vip;


        public WycieczkaKraj(string kierunek, double cena, bool vip)
            : base(kierunek, cena)
        {
            this.vip = vip;

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double Rabat()
        {
            return ((base.Rabat() * 2) * 2/3 );
        }



    }
}
