using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace A2
{
    class AutoComparer : IComparer
    {
        protected bool reverse = false;

        public bool Reverse
        {
            get { return this.reverse; }
            set { this.reverse = value; }
        }

        public int Compare(object x, object y)
        {
            if (x.GetType() != typeof(Auto) || y.GetType() != typeof(Auto))
                throw new ArgumentException("Comparable object has to be of type Auto");
            
            Auto AutoX = (Auto)x;
            Auto AutoY = (Auto)y;

            int compare = String.Compare(AutoX.Marke, AutoY.Marke);

            if (this.Reverse)
                compare *= -1;

            return compare;
        }
    }
}
