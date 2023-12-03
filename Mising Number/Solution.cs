using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mising_Number
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int totalSum = n * (n + 1) / 2;
            for (int i = 0; i < n; i++)
            {
               totalSum = totalSum - nums[i];
            }
            return totalSum;
        }
    }
}
