using System;
using System.Collections.Generic;

namespace A2
{
    partial class Auto
    {
        protected string marke;
        protected string modell;
        protected string farbe;
        protected int vmax;
        protected int ps;
        protected int sitze;
        protected double verbrauch;

        public string Marke
        {
            get { return this.marke; }
            set { this.marke = value; }
        }

        public string Modell
        {
            get { return this.modell; }
            set { this.modell = value; }
        }

        public string Farbe
        {
            get { return this.farbe; }
            set { this.farbe = value; }
        }

        public int VMax
        {
            get { return this.vmax; }
            set { this.vmax = value; }
        }

        public int PS
        {
            get { return this.ps; }
            set { this.ps = value; }
        }

        public int Sitze
        {
            get { return this.sitze; }
            set { this.sitze = value; }
        }

        public double Verbrauch
        {
            get { return this.verbrauch; }
            set { this.verbrauch = value; }
        }
    }
}
