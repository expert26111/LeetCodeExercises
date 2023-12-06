using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Maximum_Number_Of_Ballons
{
    public class Solution
    {
        public int maxNumberOfBalloons(String text)
        {
            Dictionary<char,int> table = new Dictionary<char,int>();
            char[] chars = text.ToCharArray();   
            for(int i = 0;i< chars.Length;i++)
            {
                char current = chars[i];
                if (checkCharacter(current))
                {
                    table[current] = table.GetValueOrDefault(current, 0) + 1;           
                }                      
            }
            int min = 0;
            if(table.Count>=5)
            {
                 min = table.Values.Aggregate((current, next) => current <= next ? current : next);
            }
            else
            {
                return 0;
            }
          
            if (table['l'] < 2 || table['o'] < 2 || min == 0)
            {
                return 0;
            }
            else if(table['l'] >= 2 * min && table['o'] >= 2 * min)
            {             
                    return min;              
            }else
            {
                int smallerOfLORO = Math.Min(table['l'], table['o']);
                if(min <= smallerOfLORO) 
                {
                    if(min>= smallerOfLORO/2)
                    {
                        return smallerOfLORO / 2;
                    }
                    return min;
                }
                else
                {
                    return 0;
                }
            }
            bool checkCharacter(char c) 
            {
                switch (c)
                {
                    case 'b':
                        return true;                     
                    case 'a':
                        return true;
                    case 'l':
                        return true;
                    case 'o':
                        return true;
                    case 'n':
                        return true;
                }
                return false;
            }

            
        }
    }
}

