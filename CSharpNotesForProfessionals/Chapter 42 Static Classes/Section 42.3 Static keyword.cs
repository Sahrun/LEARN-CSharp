using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_42_Static_Classes_Section_43
{
    public class Foo
    {
        public Foo()
        {
            Counter++;
            NonStaticCounter++;
        }
        public static int Counter { get; set; }
        public int NonStaticCounter { get; set; }
    }
}
