

//int[] nums = { -1, 0, 3, 5, 9, 12 };
//int target = 9;

int[] nums2 = { 1, 0, 3, 5, 9, 12 };
int target = 2;
Console.WriteLine(Search(nums2,target));
int Search(int[] nums, int target)
{
    Array.Sort(nums);
    int startIndex = 0;
    int endIndex = nums.Length - 1;

    while (startIndex <= endIndex)
    {
        int midIndex = (endIndex - startIndex) / 2 + startIndex;
        if (nums[midIndex] == target) { return midIndex; }
        else if (nums[midIndex] < target) { startIndex = midIndex+1; }
        else  { endIndex = midIndex-1; }
    }
    return -1;
}


