
int[] nums1 = { 4, 1, 2 };
int[] nums2 = { 1, 3, 4, 2 };

int[] answer = NextGreaterElement(nums1, nums2);
for(int i = 0; i < answer.Length; i++)
{
    Console.WriteLine(answer[i]);
}

 int[] NextGreaterElement(int[] nums1, int[] nums2)
{
    int returnNextGreaterInNums2(int startIndex, int element)
    {
       for(int i = startIndex+1; i < nums2.Length; i++) 
        {
            if (nums2[i]>element)
            {
                return nums2[i];
            }
        }
        return -1;
    }

    IList<int> answer = new List<int>();
    //num, index
    IDictionary<int,int> table= new Dictionary<int,int>();
    for(int i = 0; i < nums2.Length;i++)
    {
        table[nums2[i]] = i; 
    }
    for(int i = 0; i < nums1.Length;i++)
    {
        int element = nums1[i];
        int indexInNums2 = table[element];
        answer.Add(returnNextGreaterInNums2(indexInNums2,element));
    }
    return answer.ToArray();
}