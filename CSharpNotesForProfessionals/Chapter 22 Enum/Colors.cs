using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_22_Enum
{
    [Flags]
    enum Colors
    {
        Red = 1, Blue = 2, Green = 4, RedYellow = 8
    }
}
