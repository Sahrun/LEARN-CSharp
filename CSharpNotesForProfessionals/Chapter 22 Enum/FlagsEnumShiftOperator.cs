using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_22_Enum
{
    [Flags]
    enum FlagsEnumShiftOperator
    {
        None = 0,
        Option1 = 1 << 0,
        Option2 = 1 << 1,
        Option3 = 1 << 2,

        Default = Option1 | Option3,

        All = Option1 | Option2 | Option3,

    }
}
