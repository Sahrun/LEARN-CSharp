using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section12.Section11._2Correctlyreversingastring
{
    public static class StringReverse
    {

        private static List<string> GraphemeClusters(string s)
        {
            List<string> ls = new List<string>();

            TextElementEnumerator enumerator = StringInfo.GetTextElementEnumerator(s);

            while (enumerator.MoveNext())
            {
                ls.Add((string)enumerator.Current);
            }

            return ls;
        }

        private static string ReverseGraphemeClusters(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            List<string> ls = GraphemeClusters(s);

            return string.Join("", ls.ToArray());

        }

        public static void ReverseStringAndView(string s)
        {
            string reverse = ReverseGraphemeClusters(s);
            Console.WriteLine(reverse);
        }

    }




}
