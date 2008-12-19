using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Luftfahrzeug : Fahrzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Luftfahrzeug bewegt sich in der Luft");
        }

        public virtual void abheben()
        {
            Console.WriteLine("Luftfahrzeug hebt ab");
        }

        public virtual void landen()
        {
            Console.WriteLine("Luftfahrzeug landet");
        }
    }
}
