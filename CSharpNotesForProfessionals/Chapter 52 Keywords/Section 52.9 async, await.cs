using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_9
{
    internal class Section_52_9
    {
        internal async Task DoSomethingAsync()
        {
            Console.WriteLine("Starting a useless process...");
            Stopwatch stopwatch = Stopwatch.StartNew();
            int delay = await UselessProcessAsync(1000);
            stopwatch.Stop();
            Console.WriteLine("A useless process took {0} milliseconds to execute.",
            stopwatch.ElapsedMilliseconds);
        }

        internal async Task<int> UselessProcessAsync(int x)
        {
            await Task.Delay(x);
            return x;
        }

        internal Task PrintAndDelayAsync(string message, int delay)
        {
            Console.WriteLine(message);
            return Task.Delay(delay);
        }

    }

}
