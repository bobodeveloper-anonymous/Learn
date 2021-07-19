using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn.Kata
{
    public class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null || iterable.Count() == 0)
                yield break;
            T previous = default;
            foreach (T next in iterable)
            {
                if (!next.Equals(previous))
                {
                    previous = next;
                    yield return next;                    
                }
            }
        }
    }
}
