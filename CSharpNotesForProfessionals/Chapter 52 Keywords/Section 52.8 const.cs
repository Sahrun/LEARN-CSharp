using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_8
{
    internal class Section_52_8
    {
        const double c = 299792458;
        private const double cP = 299792458;
        public const double cPB = 299792458;
        internal const double cI = 299792458;

       internal double CalculateEnergy(double mass)
        {
            const double c = 299792458;
            return mass * c * c;
        }



    }
}
