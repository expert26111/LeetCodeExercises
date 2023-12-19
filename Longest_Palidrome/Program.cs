

using System.Reflection.Metadata;

//string s = "abccccdd";
//string s2 = "bananas";
//string s3 = "abccccdd";
string s4 = "ababababa";
Console.WriteLine(LongestPalindrome(s4));

int LongestPalindrome(string s)
{
    
    if(s.Length ==  1) { return 1; }
    int counter = 0;
    int oddCount = -1;
  
    Dictionary<char, int> occurences = new Dictionary<char, int>(23);
    foreach (char ch in s)
    {
        occurences[ch] = occurences.GetValueOrDefault(ch, 0) + 1;
    }

    foreach (KeyValuePair<char, int> entry in occurences)
    {
        if (entry.Value % 2 == 0)
        {
            counter += entry.Value;
        }
        else
        {
            counter += entry.Value;
            oddCount++;
        }
    }

    if(oddCount!= -1) { return counter - oddCount; }
    return counter;
}