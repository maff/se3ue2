using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Bagger : Kettenfahrzeug
    {
        public override void steuern()
        {
            base.steuern();
            Console.WriteLine("Bagger wird durch Joysticks in der Führerkabine gesteuert");
        }

        public void schaufeln()
        {
            Console.WriteLine("Baggerschaufel wird durch einen Joystick in der Führerkabine betätigt");
        }
    }
}
