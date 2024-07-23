using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_43_Singleton_Implementation_Section_43_1
{
    public class Singleton
    {
        private readonly static Singleton instance = new Singleton();
        private Singleton() { }
        public static Singleton Instance => instance;
    }
}
