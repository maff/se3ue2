using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duesenflugzeug duesenflugzeug = new Duesenflugzeug();
            duesenflugzeug.abheben();
            Console.WriteLine();
            duesenflugzeug.steuern();
            Console.WriteLine();
            duesenflugzeug.landen();

            Console.WriteLine("\n---\n");

            Hubschrauber hubschrauber = new Hubschrauber();
            hubschrauber.abheben();
            Console.WriteLine();
            hubschrauber.steuern();
            Console.WriteLine();
            hubschrauber.landen();

            Console.WriteLine("\n---\n");

            PKW pkw = new PKW();
            pkw.beschleunigen();
            Console.WriteLine();
            pkw.bremsen();
            Console.WriteLine();
            pkw.steuern();

            Console.WriteLine("\n---\n");

            Segelboot segelboot = new Segelboot();
            segelboot.beschleunigen();
            Console.WriteLine();
            segelboot.bremsen();
            Console.WriteLine();
            segelboot.steuern();

            Console.ReadLine();
        }
    }
}
