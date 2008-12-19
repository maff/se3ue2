using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Radfahrzeug : Landfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Radfahrzeug wird durch Bewegen der Antriebsräder beschleunigt");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Radfahrzeug wird durch Reibung an den Rädern gebremst");
        }
    }
}
