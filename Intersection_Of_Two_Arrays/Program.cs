

int[] nums1 = { 1, 2, 2, 1 }, nums2 = { 2, 2 };
int[] array = Intersection(nums1,nums2);
foreach(int i in array)
{
    Console.WriteLine(i);
}


 int[] Intersection(int[] nums1, int[] nums2)
{
    HashSet<int> numbers1 = new HashSet<int>(nums1);
    HashSet<int> numbers2 = new HashSet<int>(nums2);
    return numbers1.Intersect(numbers2).ToArray();
}
