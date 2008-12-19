using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Wasserfahrzeug : Fahrzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Wasserfahrzeug bewegt sich auf dem Wasser");
        }
    }
}