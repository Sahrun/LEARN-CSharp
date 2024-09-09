using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_39
{
    internal class Section_52_39
    {
        private static object _lockObj = new object();
        internal Section_52_39()
        {
            Task.Run(() => TaskWork());
            Task.Run(() => TaskWork());
            Task.Run(() => TaskWork());
        }

        private static void TaskWork()
        {
            //lock (_lockObj)
            //{
            Console.WriteLine("Entered");
            Task.Delay(3000);
            Console.WriteLine("Done Dalaying");

            // Access shered resource safely
            Console.WriteLine("leaving");
            //}
        }
    }
}
