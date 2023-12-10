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
                //table[num] = table[num] += 1;
            }

           var list = table.OrderByDescending(x => x.Value).Select(el => el.Key).Take(k).ToArray();
            return list;
            //int[] result = new int[k];
            //for(int i = 0; i < k; i++)
            //{
            //    result[i] = table[i];
            //}
            //return result;
        }

    }
}
