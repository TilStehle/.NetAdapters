﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
    class Runtime
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
      
        internal static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }
}
