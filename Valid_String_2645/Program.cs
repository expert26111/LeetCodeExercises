



long AddMinimum(string word)
{
    short order = 0;
    string pattern = "abc";
    short i = 0;
    short count = 0;
    while( i < word.Length)
    {
        if (pattern[order % 3] == word[i])
        {       
           i++;
        }
        else
        {
            count++;
        }
        order++;
    }
    int ostatuk = order % 3;
    if(ostatuk==0)
    {
        return count;
    }
    else
    {
        int num = 3 - order % 3;
        return num + count;
    }
}
