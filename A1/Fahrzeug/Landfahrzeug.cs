using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Landfahrzeug : Fahrzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Landfahrzeug bewegt sich auf dem Land");
        }
    }
}
