using System;
using System.Linq;
using System.Collections.Generic;

namespace Alalgorithmic.Lib
{
	public static class ListFilterer
	{
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            if (listOfItems is null)
                throw new ArgumentNullException(nameof(listOfItems));

            return listOfItems.OfType<int>();
        }
    }
}
