

int num = 2147395599;
//int num2 = 4;
//int num3 = 8;
Console.WriteLine(MySqrt(num));

 int MySqrt(int x)
{
    if (x <= 1) return x;
    long smaller = 0;
    long mid = 0;
    int start = 0;
    int end = x/2;
    while (start<= end)
    {
        mid = (end - start)/2 + start;
        if (mid*mid == x) { return (int)mid; }
        if(mid*mid >x) { end = (int)mid - 1; }
        if(mid*mid < x) { start = (int)mid + 1; smaller = mid; }
    }

    if(mid*mid > x)
    {
        return (int)smaller;
    }
    return (int)mid;
}
