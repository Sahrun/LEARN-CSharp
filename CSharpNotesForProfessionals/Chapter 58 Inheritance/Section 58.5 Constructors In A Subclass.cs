using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_58_Inheritance_Section_58_5
{
    internal class Instrument
    {
        string type;
        bool clean;

        public Instrument(string type, bool clean)
        {
            this.type = type;
            this.clean = clean;
        }
    }

    internal class Trumpet : Instrument
    {

        bool oiled;
        public Trumpet(string type, bool clean, bool oiled) : base(type, clean)
        {
            this.oiled = oiled;
        }
    }
}
