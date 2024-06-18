using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_22_Enum
{
    public enum PossibleResults
    {
        [Description("Success")]
        OK = 1,
        [Description("File not found")]
        FileNotFound = 2,
        [Description("Access denied")]
        AccessDenied = 3,
    }
}
