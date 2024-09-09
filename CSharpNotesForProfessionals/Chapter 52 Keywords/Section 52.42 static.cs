using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter_52_Keywords_Section_52_42
{
    public class ClassStatic
    {
        static public int count = 0;

        static public DateTime InitializationTime;

        public ClassStatic()
        {
            count++;
        }

        static ClassStatic()
        {
            InitializationTime = DateTime.Now;
            Console.WriteLine(InitializationTime.ToString());
        }

    }

    public class ConsoleAppsStatic
    {
        public static void Main()
        {

            WriteLine("Hallo , Word , Static");
        }
    }
}
