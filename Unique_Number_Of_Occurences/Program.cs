


Console.WriteLine("Hello, World!");

bool UniqueOccurrences(int[] arr)
{
    Dictionary<int, int> occurences = new Dictionary<int, int>();
    for(int i = 0; i < arr.Length; i++)
    {
        int current = arr[i];
        occurences[current] = occurences.GetValueOrDefault(current, 0) + 1;
    }
    List<int>[] bucket= new List<int>[arr.Length+1];
    for(int i = 0; i < bucket.Length; i++) { bucket[i] = new List<int>(); }
    foreach (KeyValuePair<int, int> entry in occurences)
    {
        bucket[entry.Value].Add(1);
        if (bucket[entry.Value].Count > 1)
        {
            return false;
        }
    }
    return true;
}

