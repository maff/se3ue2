using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Kettenfahrzeug : Landfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Kettenfahrzeug wird durch Bewegen der Antriebsketten beschleunigt");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Kettenfahrzeug wird durch Bremswirkung auf die Antriebsketten gebremst");
        }
    }
}
