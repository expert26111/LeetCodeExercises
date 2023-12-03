// See https://aka.ms/new-console-template for more information
using Mising_Number;

Console.WriteLine("Hello, World!");

//int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
int[] nums = { 0, 2 };
Solution sol = new Solution();
Console.WriteLine("The missing element is: {0}", sol.MissingNumber(nums));
