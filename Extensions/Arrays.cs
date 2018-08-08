using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone
{
        public class Arrays
        {
            public static IList<T> AsList<T>(T[] array)
            {
                return new List<T>(array);
            }
        }
}
