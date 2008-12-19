using System;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    partial class Auto : IComparable
    {
        public Auto()
        {
        }

        public Auto(string marke, string modell, string farbe, int vmax, int ps, int sitze, double verbrauch)
        {
            this.Marke = marke;
            this.Modell = modell;
            this.Farbe = farbe;
            this.VMax = vmax;
            this.PS = ps;
            this.Sitze = sitze;
            this.Verbrauch = verbrauch;
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() != typeof(Auto))
                throw new ArgumentException("Comparable object has to be of type Auto");

            Auto auto = (Auto)obj;
            return String.Compare(this.Marke, auto.Marke);
        }

    }
}