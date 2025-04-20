using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_908
    {
        ////(908.) Smallest Range I (EASY)
        public int SmallestRangeI(int[] nums, int k)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                if (currValue > max)
                {
                    max = currValue;
                }
                if(currValue < min)
                {
                    min = currValue;
                }
            }
            int currMin = min + k;
            int currMax = max - k;
            int diff = currMax - currMin;
            
            if (diff <= 0)
            {
                return 0;
            }
            else
            {
                return diff;
            }
        }
    }
}
