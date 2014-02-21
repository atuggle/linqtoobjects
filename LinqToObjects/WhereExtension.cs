using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    public static class WhereExtension
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, Boolean> predicate)
        {
            foreach (var currentObject in list)
                if (predicate(currentObject))
                    yield return currentObject;

            yield break;
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> list, Func<T, Int32, Boolean> predicate)
        {
            var count = 0;
            foreach (var currentObject in list)
                if (predicate(currentObject, count++))
                    yield return currentObject;

            yield break;
        }
    }
}
