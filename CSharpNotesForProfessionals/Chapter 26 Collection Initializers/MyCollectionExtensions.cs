using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Collection_Initializers
{
    static class MyCollectionExtensions
    {
        public static void Add(this MyCollection @this, double value)
        {
            @this.Add(value);
        }
    }
}
