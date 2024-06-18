using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11.Section_11._13_Determine_whether_a_string_begins_with_a_given
{
    public static class StartWithandContainString
    {
        public static void CheckStartString(string value, string find)
        {
            Console.WriteLine($"The {value} contain  prefix {find} : {value.StartsWith(find)}");
        }

        public static void CheckEndString(string value, string find)
        {
            Console.WriteLine($"The {value} contain  end {find} : {value.EndsWith(find)}");
        }

        public static void CheckContainString(string value, string find)
        {
            Console.WriteLine($"The {value} contain {find} : {value.Contains(find)}");
        }
    }
}
