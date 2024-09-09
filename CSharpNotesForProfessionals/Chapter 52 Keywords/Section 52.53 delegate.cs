using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_52_Keywords_Section_52_53
{
    internal class DelegateExample
    {
        internal void Run()
        {
            // using class method
            InvokeDelegate(WriteToconsole);

            // using anonymous method
            DelegateInvoker di = delegate (string input)
            {
                Console.WriteLine(string.Format("di : {0}", input));
                return true;
            };

            InvokeDelegate(di);

            // using lamda
            InvokeDelegate(input => false);
        }


        public delegate bool DelegateInvoker(string input);

        public void InvokeDelegate(DelegateInvoker func)
        {
            var ret = func("Hello Word");
            Console.WriteLine(string.Format(" > delegate returned {0}", ret));
        }

        public bool WriteToconsole(string input)
        {
            Console.WriteLine(string.Format("WriteToConsole: {0}", input));
            return true;
        }
    }
}
