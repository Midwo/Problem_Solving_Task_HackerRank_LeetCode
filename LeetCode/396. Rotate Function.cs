using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_396
    {
        ////(396.) Rotate Function (MEDIUM)
        public int MaxRotateFunction(int[] nums)
        {
            int length = nums.Length;
            int sumNums = 0;
            int currFk = 0;
            int multiplier = 0;

            foreach (int num in nums) 
            { 
                sumNums += num;
                currFk += num * multiplier++;
            }

            int maxSum = currFk;

            for (int i = 1; i < length; i++)
            {
                currFk += sumNums - length * (nums[length - i]);
                maxSum = maxSum < currFk ? currFk : maxSum;
            }

            return maxSum;
        }
    }
}
