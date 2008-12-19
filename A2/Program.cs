using System;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] Autos = {
                new Auto("BMW", "X5", "Schwarz", 230, 180, 5, 9.8),
                new Auto("Opel", "Corsa", "Rot", 160, 70, 4, 6.5),
                new Auto("Audi", "A4 Avant", "Silber", 215, 120, 5, 7.7)
            };

            AutoComparer Comparer = new AutoComparer();
            Comparer.Reverse = true;

            //Array.Sort(Autos);
            Array.Sort(Autos, Comparer);
            printAutos(Autos);

            Console.ReadLine();
        }

        static void printAutos(Auto[] autos)
        {
            foreach (Auto auto in autos)
            {
                Console.WriteLine("{0} {1} ({2}) - {3} Sitze", auto.Marke, auto.Modell, auto.Farbe, auto.Sitze);
                Console.WriteLine("VMax: {0}", auto.VMax);
                Console.WriteLine("PS: {0}", auto.PS);
                Console.WriteLine("Verbrauch: {0}/100km", auto.Verbrauch);
                Console.WriteLine();
            }
        }
    }
}
