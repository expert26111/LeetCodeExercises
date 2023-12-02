// See https://aka.ms/new-console-template for more information



using MajorityEvenElement;

int[] nums = { 0, 1, 2, 2, 4, 4, 1 };
Solution sol = new Solution(); 
int element = sol.MostFrequentEven(nums);
Console.WriteLine(element);



//Dictionary<int,int> table = new Dictionary<int,int>();
//foreach (KeyValuePair<int, int> entry in table)
//{
//    Console.WriteLine("The Key is:{0}, the Value is: {1}", entry.Key, entry.Value);
//}

//table.Add(0, 3);
//int valu = table.GetValueOrDefault(0,0)+1;

//foreach (KeyValuePair<int, int> entry in table)
//{
//    Console.WriteLine("The Key is:{0}, the Value is: {1}",entry.Key,entry.Value);
//}

//Console.WriteLine("The value is: {0}", valu);


