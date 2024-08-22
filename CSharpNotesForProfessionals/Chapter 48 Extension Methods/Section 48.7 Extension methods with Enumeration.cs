using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_7
{

    public enum YesNo
    {
        Yes,
        No
    }

    public enum Element
    {
        Hydrogenn,
        Helium,
        Lithium,
        Beryllium,
        Boron,
        Carbon,
        Nitrogen,
        Oxygen
    }

    public static class EnumExtensions
    {
        public static bool ToBool(this YesNo yn)
        {
            return yn == YesNo.Yes;
        }

        public static YesNo ToYesNo(this bool yn)
        {
            return yn ? YesNo.Yes : YesNo.No;
        }

        public static double AntomicMass(this Element element)
        {
            switch (element)
            {
                case Element.Hydrogenn: return 1.00794;
                case Element.Helium: return 4.002602;
                case Element.Lithium: return 6.941;
                case Element.Beryllium: return 9.012182;
                case Element.Boron: return 10.811;
                case Element.Carbon: return 12.0107;
                case Element.Nitrogen: return 14.0067;

            }

            return double.NaN;

        }
    }
}
