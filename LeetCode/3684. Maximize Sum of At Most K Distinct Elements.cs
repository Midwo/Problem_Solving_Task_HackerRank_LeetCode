using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3684
    {
        ////(3684.) Maximize Sum of At Most K Distinct Elements (EASY)
        public int[] MaxKDistinct(int[] nums, int k)
        {
            Array.Sort(nums);
            List<int> result = new List<int>();

            int lastValue = int.MaxValue;
            for (int i = nums.Length-1; i >= 0; i--)
            {
                if(lastValue != nums[i])
                {
                    lastValue = nums[i];
                    result.Add(lastValue);
                    if (result.Count == k)
                    {
                        break;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
