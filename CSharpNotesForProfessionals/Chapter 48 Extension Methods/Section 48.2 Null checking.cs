using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_Section_48_2_Null_checking
{
    public static class StringExtensions1
    {
        public static string EmptyIfNull(this string text)
        {
            return text ?? String.Empty;

        }


        public static string NullIfEmpty(this string text)
        {
            return String.Empty == text ? null : text;
        }
    }
}
