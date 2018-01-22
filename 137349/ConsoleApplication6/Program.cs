using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Wycieczka> biuroPodrozy = new List<Wycieczka>();

            biuroPodrozy.Add(new Wycieczka("Paryz", 2000));
            biuroPodrozy.Add(new Wycieczka("Holndia", 1000));
            biuroPodrozy.Add(new Wycieczka("Belgia", 1200));
            
            biuroPodrozy.Add(new WycieczkaKraj("Krakow", 3200, true));
            biuroPodrozy.Add(new WycieczkaKraj("Poznan", 200, false));
            biuroPodrozy.Add(new WycieczkaKraj("Warszawa", 500, false));


            foreach (var bp in biuroPodrozy)
            {
                Console.WriteLine("rabat: " + bp.Rabat());
            }
            Console.WriteLine("-------------------------");
            foreach (var bp in biuroPodrozy)
            {
                Console.WriteLine(bp.ToString());
            }

            Console.WriteLine("-------------------------");
            biuroPodrozy.Sort();

            Console.WriteLine("\n\npo sortowaniu:");
            foreach (var bp in biuroPodrozy)
            {
                Console.WriteLine(bp.ToString());
            }

            biuroPodrozy.Reverse();
            Console.WriteLine("-------------------------");

            Console.WriteLine("\n\nodwrocenie kolejnosci:");
            foreach (var bp in biuroPodrozy)
            {
                Console.WriteLine(bp.ToString());
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("\n\nelementy o nieparzystych indeksach:");
            int index = 0;

            while (index < biuroPodrozy.Count)
            {
                if (index % 2 == 0)
                    Console.WriteLine(biuroPodrozy[index]);
                index++;
            }
            Console.WriteLine("-------------------------");
            Dictionary<string, float> hotel = new Dictionary<string, float>();

            hotel.Add("hotel 1", 500);
            hotel.Add("hotel 2", 1000);
            hotel.Add("hotel 3", 700);
            hotel.Add("hotel 4", 1500);
            hotel.Add("hotel 5", 2000);

            Console.WriteLine("\n\nhotele:");
            foreach (var hot in hotel)
            {
                Console.WriteLine(hot.Key + " : " + hot.Value);
            }
            Console.WriteLine("-------------------------");
            Queue<WycieczkaKraj> pensjonat = new Queue<WycieczkaKraj>();

            pensjonat.Enqueue(new WycieczkaKraj("Krakow", 2000, false));
            pensjonat.Enqueue(new WycieczkaKraj("Gdansk", 5000, true));
            pensjonat.Enqueue(new WycieczkaKraj("Warszawa", 1200, false));
            pensjonat.Enqueue(new WycieczkaKraj("Poznan", 5000, false));
            pensjonat.Enqueue(new WycieczkaKraj("Lodz", 3000, false));

            Console.WriteLine("\n\nelementy pensjonat: ");
            foreach (var pen in pensjonat)
            {
                Console.WriteLine(pen.ToString());
            }


            Rezerwacje rez = new Rezerwacje();

            rez.Dodaj("rezerwacja 1");
            rez.Dodaj("rezerwacja 2");
            rez.Dodaj("rezerwacja 3");

            rez.Dodaj('a');
            rez.Dodaj('b');
            rez.Dodaj('c');

            rez.Usun();
            rez.Usun();
            rez.Usun();

            Samolot samolot = new Samolot("f16");

            Console.ReadKey();
        }


    }
}
