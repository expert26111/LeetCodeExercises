

namespace MajorityElements
{
    public class Solution
    {
        public static IList<int> majorityElements(int[] nums)
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
                else if(count1 == 0)
                {
                    count1++;
                    cand1 = nums[i];
                }else if(count2 == 0)
                {
                    count2++;
                    cand2 = nums[i];
                }
                else
                {
                    count1--;
                    count2--;
                }

                    
            }

            count1 = 0;
            count2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == cand1)
                {
                    count1++;
                }
                if (nums[i] == cand2)
                {
                    count2++;
                }
            }

            if(cand1 == cand2)
            {
                if (count1 > threshold)
                {
                    result.Add(cand1);
                    //  count1 = 0;
                }
            }
            else
            {
                if (count1 > threshold)
                {
                    result.Add(cand1);
                    //  count1 = 0;
                }

                if (count2 > threshold)
                {
                    result.Add(cand2);
                    //count2 = 0;

                }
            }

  
            return result.ToArray();
        }
    }
}
