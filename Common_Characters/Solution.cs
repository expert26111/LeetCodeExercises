using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Characters
{
    public class Solution
    {
        public List<String> commonChars(String[] words)
        {
            int wordNumber = words.Length;
            List<String> result = new List<String>();
            Dictionary<char,int> table = new Dictionary<char,int>();
            foreach(char sign in words[0])
            {
                table[sign] = table.GetValueOrDefault(sign, 0) + 1;
            }

            for(int i = 1; i < words.Length; i++)
            {
                char[] characters = words[i].ToCharArray();
                for(int j = 0; j<characters.Length;j++)
                {
                    if (table.ContainsKey(characters[j]))
                    {
                        result.Add(characters[j].ToString());
                   
                    }
                }
            }
            return (List<string>)result;

        }
    }
}
