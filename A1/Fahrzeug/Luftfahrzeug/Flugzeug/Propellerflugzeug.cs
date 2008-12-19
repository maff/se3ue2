using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Propellerflugzeug : Flugzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Propellerflugzeug beschleunigt durch Drehzahl der Propellers");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Propellerflugzeug bremst durch Radbremse");
        }
    }
}
