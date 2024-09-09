using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter_52_Keywords_Section_52_59
{
    public class Section_52_59
    {
        public Section_52_59()
        {
            int i = 0;

            do
            {
                WriteLine("Do is on loop number  {0}.", i);
            } while (i++ < 5);


            bool a = false;

            do
            {
                WriteLine("This will be printed once, even id a is false");

            } while (a == true);
        }
    }
}
