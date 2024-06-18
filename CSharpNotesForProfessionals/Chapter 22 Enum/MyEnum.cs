using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_22_Enum
{
    [Flags]
    enum MyEnum
    {
        //None = 0, can be used but not combained in bitwise operations
        FlagZ = 0,
        FlagA = 1,
        FlagB = 2,
        FlagC = 4,
        FlagD = 8
    }
}
