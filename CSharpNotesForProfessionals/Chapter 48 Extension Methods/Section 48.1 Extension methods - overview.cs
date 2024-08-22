using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_48_Extension_Methods_overview
{
    static class StringExtensions
    {
        public static string Shorten(this string text, int length)
        {
            return text.Substring(0, length);
        }
    }


    class Test
    {
        public void Hello()
        {
            Console.WriteLine("From Test");
        }
    }


    static class TestExtensions {

        public static void Hello(this Test test)
        {
            Console.WriteLine("From extension method");
        }
    }
    
}
