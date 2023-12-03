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
                if(result.ContainsKey(num))
                {
                    result.Remove(num);
                }
                else
                {
                    result.Add(num, -1);
                }
            }
            return result.Keys.First();
        }
    }
}
