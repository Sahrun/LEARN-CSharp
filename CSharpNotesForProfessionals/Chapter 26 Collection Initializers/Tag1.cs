using Chapter_26_Collection_Initializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_26_Collection_Initializers
{
    public class Tag1
    {
        public Tag1()
        {
            Synonyms = new List<string>();
        }

        public List<string> Synonyms { get; private set; }
    }
}
