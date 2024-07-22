using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_42_Static_Classes
{
    public static class Foo
    {
      
        public static int Counter { get; set; }
        public static int GetCount()
        {
            return Counter;
        }
    }
}
