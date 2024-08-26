namespace LibraryManagementSystem.Utilities
{
    public static class CollectionIterator
    {
        public static IEnumerable<T> GetIterator<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                yield return item;
            }
        }
    }
}
