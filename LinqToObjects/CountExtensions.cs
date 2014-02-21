using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    public static class Extension
    {
        public static Int32 Count<T>(this IEnumerable<T> list)
        {
            var count = 0;
            foreach (var currentObject in list)
                count++;

            return count;
        }

        public static Int32 Count<T>(this IEnumerable<T> list, Func<T, Boolean> predicate)
        {
            var count = 0;
            foreach (var currentObject in list)
                if (predicate(currentObject))
                    count++;

            return count;
        }
    }
}
