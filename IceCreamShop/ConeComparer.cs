using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer :  IComparer<Cone>
    {
        public int Compare(Cone x, Cone y) //int because we are returning a value for comparison and NOT the cost which is a type double
        {
            if(x.Cost - y.Cost < 0)
            {
                return -1;
            }
            else if (x.Cost - y.Cost > 0)
            {
                return 1;
            }

            return 0; //otherwise they are equal
        }
    }
}
