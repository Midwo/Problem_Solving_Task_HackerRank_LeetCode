using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1695
    {
        ////(1695.) Maximum Erasure Value (MEDIUM)
        public int MaximumUniqueSubarray(int[] nums)
        {
            int maxSum = 0;
            int currSum = 0;
            HashSet<int> hashSetValues = new HashSet<int>();

            for (int l = 0, r = 0; r < nums.Length; r++)
            {
                while (!hashSetValues.Add(nums[r]))
                {
                    currSum -= nums[l];
                    hashSetValues.Remove(nums[l]);
                    l++;
                }
                currSum += nums[r];
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }
    }
}
