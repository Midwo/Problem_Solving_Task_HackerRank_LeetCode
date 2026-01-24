using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1877
    {
        ////(1877.) Minimize Maximum Pair Sum in Array (MEDIUM)
        public int MinPairSum(int[] nums)
        {
            int maxPairSum = int.MinValue;
            Array.Sort(nums);
            int currPairSum = 0;
            int length = nums.Length;

            for (int i = 0; i < length/2; i++)
            {
                currPairSum = nums[i] + nums[length - i - 1];
                maxPairSum = maxPairSum < currPairSum ? currPairSum : maxPairSum;
            } 

            return maxPairSum;
        }
    }
}
