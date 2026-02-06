using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3634
    {
        ////(3634.) Minimum Removals to Balance Array (MEDIUM)
        public int MinRemoval(int[] nums, int k)
        {
            Array.Sort(nums);
            int length = nums.Length;

            long minValue = nums[0];
            int indexR = 0;

            int minRemovals = length;

            for (int indexL = 0; indexL < length; indexL++)
            {
                minValue = (long)nums[indexL] * k;
                while (indexR < length)
                {
                    if (nums[indexR] > minValue)
                    {
                        break;
                    }
                    indexR++;
                }
                minRemovals = Math.Min(minRemovals, length - (indexR - indexL));

            }

            return minRemovals;
        }
    }
}
