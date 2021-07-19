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
                return new List<T>();
            
            List<T> result = new List<T>();

            result.Add(iterable.FirstOrDefault());
            foreach(T x in iterable)
            {
                if (!(result.LastOrDefault().Equals(x)))
                {
                    result.Add(x);
                }
                
            }
            return result;
        }
    }
}
