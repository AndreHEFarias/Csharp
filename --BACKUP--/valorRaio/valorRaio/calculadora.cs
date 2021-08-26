using System;
using System.Collections.Generic;
using System.Text;

namespace valorRaio
{
    class calculadora
    {
        public static double Pi = 3.14;
        public static double Cincurf(double rai)
        {
            return 2.0 * Pi * rai;
        }
        public static double Volume(double rai)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(rai, 3.0);
        }
    }
}
