using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Panzer : Kettenfahrzeug
    {
        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Panzer wird durch ein Steuerelement auf dem Fahrersitz gesteuert");
        }

        public void schiessen()
        {
            Console.WriteLine("Panzerkanone wird aus der Führerkabine aus gesteuert");
        }
    }
}
