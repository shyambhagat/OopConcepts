namespace ExtensionMethodsConcepts
{
    public static class ListExtensions
    {
        // Extension method to shuffle the elements of a List
        public static void Shuffle<T>(this List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        // Extension method to add an element to a List if it doesn't already exist
        public static void AddIfNotExists<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }

        // Extension method to get the most frequent element in a List
        public static T? MostFrequent<T>(this List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                return default;
            }

            return list.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
        }
    }
}