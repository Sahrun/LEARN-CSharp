using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_22_Enum
{
    [Flags]
    enum FlagsEnum
    {
        None = 0,
        Option1 = 1,
        Option2 = 2,
        Option3 = 4,

        Default = Option1 | Option3,
        All = Option1 | Option2 | Option3,
    }
}
