using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Motorboot : Wasserfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Motorboot beschleunigt durch Drehung der Schiffsschraube");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Motorboot bremst durch Reibung am Wasser und Drehung der Schiffsschraube in die entgegengesetzte Richtung");
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Motorboot wird durch ein Lenkrad gesteuert, das die Schiffsschraube bewegt");
        }

    }
}
