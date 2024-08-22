using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_11
{
    internal class Section_48
    {
    }

    static class StringExtensions3
    {
        public static bool IsThisAwesome(this string value)
        {
            return value.Equals("Awesome");
        }
    
    }
}
