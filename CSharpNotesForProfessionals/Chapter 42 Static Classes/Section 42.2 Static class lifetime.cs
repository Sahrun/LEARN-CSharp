using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_42_Static_Classes_Section_42
{
    public static class Foo
    {
        static Foo()
        {
            Console.WriteLine("static Foo.ctor");
        }

        public static void SayHi()
        {
            Console.WriteLine("Foo:hi");
        }
    }

    public static class Bar
    {
        static Bar()
        {
            Console.WriteLine("static Bar.ctor");
        }
    }
}
