using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3904
    {
        ////(3904.) Smallest Stable Index II (MEDIUM)
        public int FirstStableIndex(int[] nums, int k)
        {
            int length = nums.Length;
            int[] dpMinValueReverse = new int[length];

            int minValue = int.MaxValue;

            for (int index = length - 1; index >= 0; index--)
            {
                int currValue = nums[index];
                if (minValue > currValue)
                    minValue = currValue;
                dpMinValueReverse[index] = minValue;
            }

            int currMaxValue = int.MinValue;

            for (int index = 0; index < length; index++)
            {
                if (currMaxValue < nums[index])
                    currMaxValue = nums[index];

                if (currMaxValue - dpMinValueReverse[index] <= k)
                    return index;
            }

            return -1;
        }
    }
}
