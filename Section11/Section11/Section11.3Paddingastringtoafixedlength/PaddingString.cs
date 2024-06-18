using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Section11._3Paddingastringtoafixedlength
{
    public static class PaddingString
    {
        public static void Show(string s, string PT, int totalPad)
        {
            switch (PT)
            {
                case "L":
                    Console.WriteLine(s.PadLeft(totalPad));
                    break;
                case "R":
                    Console.WriteLine(s.PadRight(totalPad));
                    break;
                default:
                    Console.WriteLine("Not Defined");
                    break;


            }
        }
        public static void Show(string s, string PT, int totalPad, char opt)
        {
            switch (PT)
            {
                case "L":
                    Console.WriteLine(s.PadLeft(totalPad, opt));
                    break;
                case "R":
                    Console.WriteLine(s.PadRight(totalPad, opt));
                    break;
                default:
                    Console.WriteLine("Not Defined");
                    break;


            }
        }

    }
}
