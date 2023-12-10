using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopFrequentKElements
{
    internal class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int,int> table = new Dictionary<int,int>();
            foreach(int num in nums) 
            {
               
                 table[num] = table.GetValueOrDefault(num, 0) + 1;
            }

           return table.OrderByDescending(x => x.Value).Select(el => el.Key).Take(k).ToArray();
        }

    }
}
