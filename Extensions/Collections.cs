using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
    class Collections
    {
        public static IList<T> EmptyList<T>()
        {
            return new T[0];
        }

        internal static IList<T> UnmodifiableList<T>(IList<T> list)
        {
            return new ReadOnlyCollection<T>(list);
        }
    }
   public  static class CollectionExtensions
    { 
       public static List<T> SubList<T>(this IList<T>self, int startIndex, int endIndex)
       {
           List<T> list = new List<T>(self);

           return list.GetRange(startIndex, endIndex - startIndex);
       }
       public static void Set <T>(this IList<T> self, int replaceIndex, T newItem)
       {
           self[replaceIndex] = newItem;
       }
    }
}
