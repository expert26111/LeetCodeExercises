

using System;

//int num = 19;
int num = 3;

Console.WriteLine(IsHappy(num));

bool IsHappy(int n)
{
    string num = n.ToString();
    long newNum = calcualtionPow(num);
    Dictionary<long, int> occurences = new Dictionary<long, int>();
    while(newNum != 1 )
    {
        newNum = calcualtionPow(newNum.ToString());
        occurences[newNum] = occurences.GetValueOrDefault(newNum, 0) + 1;
        if (occurences[newNum] > 1)
        {
            return false;
        }
    }
    return true;
}

// rewrite with % and /= 
long calcualtionPow(string number)
{
    long newNum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        char num4e = number[i];
        long num4e2 = (long)(num4e - '0');
        newNum += (long)num4e2 * (long)num4e2 ;
    }
    return newNum;
}
