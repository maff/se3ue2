using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    abstract class Fahrzeug
    {
        public Fahrzeug()
        {
            this.umgebung();
        }

        public virtual void umgebung()
        {
        }

        public virtual void beschleunigen()
        {
            Console.WriteLine("Fahrzeug beschleunigt");
        }

        public virtual void bremsen()
        {
            Console.WriteLine("Fahrzeug bremst");
        }

        public virtual void steuern()
        {
            Console.WriteLine("Fahrzeug wird gesteuert");
        }
    }
}
