using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpJavaAdaptation.extensions
{
     public static class DateTime
   {
       public static bool Before(this System.DateTime? self, System.DateTime? other)
       {
           if (self != null && other != null)
               return ((DateTime)self).CompareTo((DateTime)other) < 0;
           else throw new ArgumentException ();
       }
   }
}
