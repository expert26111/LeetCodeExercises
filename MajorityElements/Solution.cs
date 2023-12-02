

namespace MajorityElements
{
    public class Solution
    {
        public IList<int> majorityElements(int[] nums)
        {
            double threshold = nums.Length / 3;

            IList<int> result = new List<int>();
            int cand1 = -1, cand2 = -1;
            int count1 = 0, count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (cand1 != -1 && nums[i] == cand1)
                {
                    count1++;
                }
                else if (cand2 != -1 && nums[i] == cand2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    cand1 = nums[i];
                    count1++;
                }
                else if (count2 == 0)
                {
                    cand2 = nums[i];
                    count2++;
                }
                else if(count1 == 1)
                {
       
                    count1 = 1;
                    cand1 = nums[i];
                }else if(count2 == 2)
                {
                    count2 = 1;
                    cand2 = nums[i];
                }
                else
                {
                    count1--;
                    count2--;
                }

                if (count1 > threshold && !result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                    count1 = 0;
                }

                if (count2 > threshold && !result.Contains(nums[i]))
                {
                    result.Add(nums[i]);
                    count2 = 0;

                }                
            }
            return result.ToArray();
        }
    }
}
