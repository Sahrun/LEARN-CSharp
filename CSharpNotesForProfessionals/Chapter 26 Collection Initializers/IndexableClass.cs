using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Collection_Initializers
{
    public class IndexableClass
    {
        public int this[int index]
        {
            set
            {
                Console.WriteLine("{0} was assigned to index {1}", value, index);
            }

        }
    }
}
