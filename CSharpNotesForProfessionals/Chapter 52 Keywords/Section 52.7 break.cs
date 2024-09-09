using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_7
{
    internal class Section_52_7
    {
        internal void Method_1()
        {
            for (var i = 0; i < 1; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("This will appear only 5 times, as the break will stop the loop.");
            }
        }

        internal void Method_2()
        {
            List<int> stuffCollection = new List<int> { 1, 2, 3, 4, 5 };

            foreach (var stuff in stuffCollection)
            {
                if (stuff == 3)
                    break;
                Console.WriteLine(stuff);
            }
        }
        internal void Method_3(int a)
        {
            switch (a)
            {
                case 5:
                    Console.WriteLine("a was 5!");
                    break;
                default:
                    Console.WriteLine("a was something else!");
                    break;
            }
        }

        internal IEnumerable<int> GetNumbers()
        {
            int i = 0;
            while (true)
            {
                if (i < 10)
                {
                    yield return i++;
                }
                else
                {
                    yield break;
                }
            }
            Console.WriteLine("This line will not be executed");
        }

    }
}
