


using System.Diagnostics.Tracing;

Console.WriteLine("Hello, World!");

 string[] FindRestaurant(string[] list1, string[] list2)
{

    Dictionary<string, int> occurences = new Dictionary<string, int>();
    for (int i = 0; i < list1.Length; i++)
    {
        occurences[list1[i]] = i;
    }
    int leastIndexSum = int.MaxValue;
  
    for (int i = 0; i < list2.Length; i++) // loop to find least sum
    {
        if (occurences.ContainsKey(list2[i]))
        {
            occurences[list2[i]] += i; // add 
            if (leastIndexSum > occurences[list2[i]])
            {
                leastIndexSum = occurences[list2[i]];
            }
        }
    }

    List<string> answer = new List<string>();
    foreach (KeyValuePair<string, int> entry in occurences)
    {
        if(entry.Value == leastIndexSum && list2.Contains(entry.Key))
        {
            answer.Add(entry.Key);
        }
    }
    return answer.ToArray();
}
