using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    public static class FirstLastExtensions
    {
        public static T First<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();
            enumerator.MoveNext();

            return enumerator.Current;
        }

        public static T First<T>(this IEnumerable<T> list, Func<T, Boolean> predicate)
        {
            foreach (var currentObject in list)
                if (predicate(currentObject))
                    return currentObject;

            throw new InvalidOperationException();
        }

        public static T Last<T>(this IEnumerable<T> list)
        {
            var enumerator = list.GetEnumerator();
            
            foreach (T currentObject in list)
                enumerator.MoveNext();

            return enumerator.Current;
        }

        public static T Last<T>(this IEnumerable<T> list, Func<T, Boolean> predicate)
        {
            var enumerator = list.GetEnumerator();

            object foundObject = null;
            foreach (T currentObject in list)
            {
                enumerator.MoveNext();
                if (predicate(currentObject))
                    foundObject = enumerator.Current;
            }

            if (foundObject != null)
                return (T)foundObject;

            throw new InvalidOperationException();
        }
    }
}
