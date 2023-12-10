using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Pattern
{
    internal class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            string delimeter = " ";
            string[] words = s.Split(delimeter);
            char[] characters = pattern.ToCharArray();

            if(words.Length != characters.Length)
            {
                return false;
            }


            Dictionary<char, List<int>> table = new Dictionary<char, List<int>>();
            for(int i = 0;i<characters.Length;i++)
            {
                char current = characters[i];
                if (table.ContainsKey(current))
                {
                    table[current].Add(i);
                }
                else
                {
                    table[current] = new List<int> { i };
                }            
            }

            foreach (KeyValuePair<char, List<int>> entry in table)
            {
                // do something with entry.Value or entry.Key
                List<int> vals = entry.Value; // all indexeses having same key, character
                                              // get first index
                string wordValue = words[vals[0]]; // this must be the value

                //redo
                for(int i = 0; i < words.Length; i++)
                {
                    if (!vals.Contains(i))
                    {
                        if (words[i] == wordValue)
                        {
                            return false;
                        }
                    }
                    else if (words[i]!=wordValue)
                    {
                        return false;
                    }
                }
            }
            return true; 
        }
    }
}
