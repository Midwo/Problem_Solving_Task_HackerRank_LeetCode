using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2670
    {
        ////(2670.) Find the Distinct Difference Array (EASY)
        public int[] DistinctDifferenceArray(int[] nums)
        {
            int length = nums.Length;
            int[] left = new int[51];
            int[] right = new int[51];
            int distinctValuesL = 0;
            int distinctValuesR = 0;
            int currValue = 0;

            for (int i = 0; i < length; i++)
            {
                currValue = nums[i];
                if (right[currValue] == 0)
                {
                    distinctValuesR++;
                }
                right[currValue]++;
            }

            for (int i = 0; i < length; i++)
            {
                currValue = nums[i];
                if (right[currValue] == 1)
                {
                    distinctValuesR--;
                    if (left[currValue] == 0)
                    {
                        left[currValue]++;
                        distinctValuesL++;
                    }
                }
                else
                {
                    right[currValue]--;
                    if (left[currValue] == 0)
                    {
                        left[currValue]++;
                        distinctValuesL++;
                    }
                }
                nums[i] = distinctValuesL - distinctValuesR;
            }
            return nums;
        }
    }
}
