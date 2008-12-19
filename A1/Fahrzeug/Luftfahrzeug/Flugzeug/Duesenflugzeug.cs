using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1
{
    class Duesenflugzeug : Flugzeug
    {
        public override void umgebung()
        {
            base.umgebung();
            Console.WriteLine("Düsenflugzeug wird meist für Langstreckenflüge eingesetzt");
        }

        public override void beschleunigen()
        {
            base.beschleunigen();
            Console.WriteLine("Düsenflugzeug beschleunigt durch Schub aus den Düsen");
        }

        public override void bremsen()
        {
            base.bremsen();
            Console.WriteLine("Düsenflugzeug bremst durch Schubumkehr und Radbremse");
        }
    }
}
