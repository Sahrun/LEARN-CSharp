using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_43_Singleton_Implementation_Section_43_2
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(()
            => new LazySingleton());

        public static LazySingleton instance
        {
            get { return _instance.Value; }
        }

        private LazySingleton() { }
    }
}
