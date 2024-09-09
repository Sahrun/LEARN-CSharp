using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_10
{
    internal class Section_52_10
    {
        internal void Method_1()
        {
            string str = "Hello";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        internal void Method_2()
        {
            for (; ; )
            {
                Console.WriteLine("Hello Word");
            }
        }

        internal void Method_3()
        {
            string hello = "hello";
            //for (int i = 0, j = 1, k = 9; i < 3 && k > 0; i++, hello += i)
            //{
            //    Console.WriteLine(hello);
            //}

            for (string i = "Hello", j = "", k = ""; i.Length > 0; i=i.Remove(i.Length - 1))
            {
                Console.WriteLine(i);
            }

        }
    }
}
