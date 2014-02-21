using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    public static class AnyExtensions
    {
        public static Boolean Any<T>(this IEnumerable<T> list)
        {
            foreach (var currentObject in list)
                return true;

            return false;
        }

        public static Boolean Any<T>(this IEnumerable<T> list, Func<T, Boolean> predicate)
        {
            foreach (var currentObject in list)
                if (predicate(currentObject))
                    return true;

            throw new InvalidOperationException();
        }
    }
}
