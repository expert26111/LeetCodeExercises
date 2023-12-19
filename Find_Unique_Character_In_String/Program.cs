
string s = "loveleetcode";
string s2 = "yekbsxznylrwamcaugrqrurvpqybkpfzwbqiysrdnrsnbftvrnszfjbkbmrctjizkjqoxqzddyfnavnhqeblfmzqgsjflghaulbadwqsyuetdelujphmlgtmkoaoijypvcajctbaumeromgejtewbwqptotrorephegyobbstvywljboeihdliknluqdpgampjyjpinxhhqexoctysfdciqjbzilnodzoihihusxluqoayenluziobxiodrfdkinkzzozmxfezfvllpdvogqqtquwcsijwachefspywdgsohqtlquhnoecccgbkrzqcprzmwvygqwddnehhi";
Console.WriteLine(FirstUniqChar(s2));
Console.WriteLine(FirstUniqChar(s2));

int FirstUniqChar(string s)
{
    Dictionary<char, int> occurences = new Dictionary<char, int>();
    char[] chars = s.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        occurences[chars[i]] = occurences.GetValueOrDefault(chars[i], 0) + 1;
    }

    char nonRepeatedCharacter = '~'; // any character
    foreach (KeyValuePair<char, int> entry in occurences)
    {
        if (entry.Value >= 2) { continue; }    
        nonRepeatedCharacter = entry.Key;
        break;

    }
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] == nonRepeatedCharacter)
        {
            return i;
        }

    }
    return -1;
}