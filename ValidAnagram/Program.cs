

using System;

string s = "anagram", t = "nagaram"; // T
string s1 = "rat", t1 = "car";// F
string s2 = "ab", t2 = "ba";  // T  
string s3 = "aa", t3 = "bb";  // F
Console.WriteLine(isAnagram(s, t));
Console.WriteLine(isAnagram(s1, t1));
Console.WriteLine(isAnagram(s2, t2));
Console.WriteLine(isAnagram(s3, t3));
bool isAnagram(String s, String t)
{
    if(s.Length != t.Length) { return false; }
    Dictionary<char, int> table = new Dictionary<char, int>();   
    int length = s.Length;
    for(int i = 0; i < length; i++)
    {
        table[s[i]] = table.GetValueOrDefault(s[i], 0) + 1;
        table[t[i]] = table.GetValueOrDefault(t[i], 0) - 1;
    }
    foreach (KeyValuePair<char, int> entry in table)
    {
        if(entry.Value != 0)
        {
            return false;
        }
    }
    return true;
}


