// See https://aka.ms/new-console-template for more information


using Common_Characters;

string[] words = { "bella", "label", "roller" };
Solution sol = new Solution();
List<string> result = sol.commonChars(words);
Console.WriteLine(result.ToString());
