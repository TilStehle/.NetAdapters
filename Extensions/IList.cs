using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CSharpJavaAdaptation.extensions
{
   
   public  static class IList
    { 
       public static List<T> SubList<T>(this IList<T> self, int startIndex, int endIndex)
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
