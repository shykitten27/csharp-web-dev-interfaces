using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer :  IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
