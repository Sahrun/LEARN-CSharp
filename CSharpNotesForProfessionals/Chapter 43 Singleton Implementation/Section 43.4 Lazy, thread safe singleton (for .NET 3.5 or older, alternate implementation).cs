using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_43_Singleton_Implementation_Section_43_4
{
    public class Singleton
    {
        private Singleton() { }

        public static Singleton Instance { get { return Nested.Instance; } }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly Singleton Instance = new Singleton();
        }
    }
}
