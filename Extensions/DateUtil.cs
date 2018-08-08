using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
   public class DateUtil
    {
        private static readonly System.DateTime Jan1st1970 = new System.DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);


        internal static System.DateTime GetDate(long millis)
        {
            return new System.DateTime(Jan1st1970.Ticks + millis * 10000000L);
        }

        
    }
   public static class ExtensionMethods
   {
       public static bool Before(this System.DateTime? self, System.DateTime? other)
       {
           if (self != null && other != null)
               return ((DateTime)self).CompareTo((DateTime)other) < 0;
           else throw new ArgumentException ();
       }
   }
}
