using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Section_11._9_Formatting_using_ToString
{
    public class FormatStringUsingToString
    {
        public static void TStringFormate(int value, string? format)
        {
            Console.WriteLine(value.ToString(format));
        }
        public static void TStringFormate(decimal value, string? format)
        {
            Console.WriteLine(value.ToString(format));
        }

        public static void TStringFormate(double value, string? formate)
        {
            Console.WriteLine(value.ToString(formate, CultureInfo.CreateSpecificCulture("us")));
        }

        public static void TStringFormate(DateTime value, string? format)
        {
            Console.WriteLine(value.ToString(format));
        }
    }
}
