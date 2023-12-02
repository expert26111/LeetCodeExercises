// See https://aka.ms/new-console-template for more information
using MajorityElements;

Console.WriteLine("Hello, World!");

Solution sol = new Solution();
//int[] nums = { 3,3,4};
int[] nums = { 4 ,2,1,1 };
Console.WriteLine("The solution is: {0} ", sol.majorityElements(nums));