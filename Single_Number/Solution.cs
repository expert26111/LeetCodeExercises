using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int,int> result = new Dictionary<int,int>();
            foreach (int num in nums) 
            {
                result[num] = result.GetValueOrDefault(num, 0) + 1;
            }
            foreach(int num in nums)
            {
                if (result[num]==1)
                {
                    return num;
                }
            }
            return -1;
        }
    }
}
