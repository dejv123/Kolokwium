using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Wycieczka : IComparable<Wycieczka>
    {
        private string kierunek;
        private double cena;

        public Wycieczka(string kierunek, double cena)
        {
            this.kierunek = kierunek;
            this.cena = cena;
        }



        public override string ToString()
        {
            return "Wycieczka: " + this.kierunek + ", cena: " + this.cena.ToString();
        }

        public virtual double Rabat()
        {
            return this.cena / 2;
        }

        public int CompareTo(Wycieczka other)
        {
            return this.cena.CompareTo(other.cena);
        }
    }
}
