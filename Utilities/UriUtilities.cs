using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJavaAdaptation.utilities
{
    class UriUtilities
    {
        public static Uri Parse(String str)
        {
            return new Uri(str);
        }
    }
}
