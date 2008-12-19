using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Flugzeug : Luftfahrzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Flugzeug bewegt sich meist in höherer Umgebung auf längeren Flügen");
        }

        public override void abheben()
        {
            base.abheben();
            this.beschleunigen();
            this.naseHochziehen();
        }

        public override void landen()
        {
            base.landen();
            this.landeklappen();
            this.fahrwerk();
            this.bremsen();
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Flugzeug wird durch Einstellung der Höhen- und Seitenruder gesteuert");
        }


        protected void naseHochziehen()
        {
            Console.WriteLine("Flugzeug zieht die Nase hoch");
        }

      
        protected void landeklappen()
        {
            Console.WriteLine("Flugzeug fährt Landeklappen aus");
        }

        protected void fahrwerk()
        {
            Console.WriteLine("Flugzeug fährt Fahrwerk aus");
        }

        
    }
}
