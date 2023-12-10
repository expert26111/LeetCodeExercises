using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuddyStrings
{
    internal class Solution
    {
        // is says specifically to swap two letters
        public bool BuddyStrings(string s, string goal)
        {
              if(s.Length != goal.Length) return false;
           //   if(s.Equals(goal)) return true;
             // Dictionary<>
              List<int> list4e = new List<int>();
              for(int i = 0; i < s.Length; i++) 
               {
                    if (s[i] != goal[i])
                    {
                        list4e.Add(i);
                    }
                    
               }

              

        //    if (s.Equals(goal) && ) return true;




            if (list4e.Count > 2)
              {
                 return false;
              }
            if(list4e.Count == 1) 
            {
                return false;
            }
            if(list4e.Count == 2)
            {
                if (s[list4e[0]] == s[list4e[1]])
                {
                    return false;
                }


                //swaping , assuming they are only two indexes
                char[] sCharacters = s.ToCharArray();
                char[] goalCharacters = goal.ToCharArray();

                char fisrtCharacter = sCharacters[list4e[0]];
                //   char secondCharacter = sCharacters[list4e[1]];

                sCharacters[list4e[0]] = sCharacters[list4e[1]];
                sCharacters[list4e[1]] = fisrtCharacter;

                string newString = new string(sCharacters);


                if (newString.Equals(goal))
                {
                    return true;

                }
                return false;


            }











            int disNum = s.Distinct().Count();
            if (disNum == s.Length && !s.Equals(goal))
            {
                return true;
            }
            if (disNum < s.Length && s.Equals(goal))
            {
                return true;
            }
            if (disNum ==  s.Length && s.Equals(goal)) 
            {
                return false;
            }


            if(list4e.Count == 0 && s.Equals(goal))
            {
                return true;
            }

            if(disNum < s.Length && !s.Equals(goal))
            {
                return true;
            }
            //if (disNum < s.Length) 
            //{
            //    return true;
            //}
    



            return false;

        }
    }
}
