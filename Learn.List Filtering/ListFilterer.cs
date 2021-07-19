using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn.ListFiltering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }
    }

}
