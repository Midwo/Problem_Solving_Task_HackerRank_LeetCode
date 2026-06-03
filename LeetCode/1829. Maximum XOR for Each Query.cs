using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1829
    {
        ////(1829.) Maximum XOR for Each Query (MEDIUM)
        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            int length = nums.Length;
            int[] result = new int[length];
            int maxK = (int)Math.Pow(2, maximumBit)-1;

            int xorValue = 0;

            for (int i = 0; i < length; i++)
            {
                xorValue ^= nums[i];
                nums[i] = xorValue;
            }

            for (int index = 0; index < length; index++)
            {
                xorValue = nums[length-index-1];

                result[index] = xorValue ^ maxK;
            }

            return result;
        }
    }
}
