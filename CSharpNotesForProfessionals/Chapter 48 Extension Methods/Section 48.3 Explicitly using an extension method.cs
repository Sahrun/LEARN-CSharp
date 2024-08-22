using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_3_Explicitly_using_an_extension_method
{
    static class StirngExtensions2
    {
        public static string Shorten2(this string text, int length)
        {
            return text.Substring(0, length);
        }
    }
}
