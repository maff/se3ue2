using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Hubschrauber : Luftfahrzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Hubschrauber befindet sich meist eher in Bodennäher auf kurzen Flügen");
        }

        public override void abheben()
        {
            base.abheben();
            Console.WriteLine("Hubschrauber hebt durch erhöhte Rotordrehzahl und Einstellung der Rotorblätter ab");
        }

        public override void landen()
        {
            base.landen();
            Console.WriteLine("Hubschrauber landet durch Einstellung der Rotorblätter");
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Hubschrauber wird durch Einstellung des Haupt- und Nebenrotors gesteuert");
        }
    }
}
