using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_3
{
    internal class ExampleVolatile
    {
        public volatile int x;

        public void DoStuff()
        {
            x = 5;
            var y = x + 10;

            Console.WriteLine($"x = {x} , y = {y}");
        }
    }
}
