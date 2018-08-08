using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
   public static class StringExtension
    {

       public static String[] Split(this String self, String splitToken)
            {
                return self.Split(new String[] { splitToken }, StringSplitOptions.RemoveEmptyEntries);
            }
    }
}
