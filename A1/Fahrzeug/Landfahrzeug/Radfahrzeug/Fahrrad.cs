using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Fahrrad : Radfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Fahrrad wird durch Treten in die Pedale beschleunigt");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Fahrrad wird durch betätigen der Handbremsen gebremst");
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Fahrrad wird durch Bewegen der Lenkstange und Gewichtsverlagerung gesteuert");
        }
    }
}
