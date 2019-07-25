using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace healthscan_BE.Enums
{
    [Flags]
    public enum ToxicityLevels
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 4,
        Hazardous = 8,
    }
}
