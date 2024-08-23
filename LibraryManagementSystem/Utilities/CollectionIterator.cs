using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utilities
{
    public static class CollectionIterator
    {
        public static IEnumerable<T> GetIterator<T>(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                yield return item;
            }
        }
    }
}
