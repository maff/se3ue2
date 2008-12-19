using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Segelboot : Wasserfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Segelboot beschleunigt durch Setzen der Segel bei entsprechendem Wind");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Segelboot bremst durch Reibung am Wasser und durch Löschen der Segel");
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Segelboot wird durch ein Steuerrad gesteuert, das das Ruder bewegt");
        }
    }
}
