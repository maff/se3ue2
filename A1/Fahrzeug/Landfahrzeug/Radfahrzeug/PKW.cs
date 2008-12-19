using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class PKW : Radfahrzeug
    {
        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("PKW wird durch betätigen des Gaspedals beschleunigt");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("PKW wird durch betätigen des Bremspedals gebremst");
        }

        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("PKW wird durch ein Lenkrad gesteuert, das die Vorderreifen bewegt");
        }
    }
}
