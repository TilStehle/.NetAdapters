 using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CSharpJavaAdaptation.utilities
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
}