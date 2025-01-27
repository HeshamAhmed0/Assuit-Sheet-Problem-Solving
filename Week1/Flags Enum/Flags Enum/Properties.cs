using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flags_Enum
{
    [Flags]
    internal enum Properties : byte
    {
        Delete = 1,
        write = 2, read = 4,
    }
}
