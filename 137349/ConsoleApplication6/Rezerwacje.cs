using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Rezerwacje : IOperacje
    {

        public List<string> stos = new List<string>();

        public void Dodaj(string nazwa)
        {
            this.stos.Add(nazwa);
        }
        public void Dodaj(char ch)
        {
            this.stos.Add(ch.ToString());
        }

        public void Usun()
        {
            this.stos.RemoveAt(0);
        }
    }
}
