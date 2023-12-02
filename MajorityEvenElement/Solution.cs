using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityEvenElement
{
    public class Solution
    {
       public int MostFrequentEven(int[] nums)
        {
           // Hashtable table = new Hashtable();
           Dictionary<int,int> table = new Dictionary<int,int>();
            int timesOccurences = 0;
            int element = -1;

            for(int i = 0; i < nums.Length; i++) 
            {
                int current = nums[i];
                if (current%2 == 0)
                {
                    table[current] = table.GetValueOrDefault(current, 0) + 1;
                    if (table[current] > timesOccurences) 
                    {
                        element = current;
                        timesOccurences = table[current];
                    }else if (table[current] == timesOccurences && current < element)
                    {
                        element = current;
                    }
                }
            }
            return element;

        }
    }
}
