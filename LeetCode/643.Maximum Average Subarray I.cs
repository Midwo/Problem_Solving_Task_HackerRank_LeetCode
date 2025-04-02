using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_643
    {
        ////643.Maximum Average Subarray I (EASY)
        public double FindMaxAverage(int[] nums, int k)
        {
            int length = nums.Length;
            double result = 0;

            for (int i = 0; i < k; i++)
            {
                result += nums[i];
            }

            double maxAverage = result;

            for (int i = k; i < length; i++)
            {
                result += nums[i];
                result -= nums[i - k];

                maxAverage = maxAverage < result ? result : maxAverage;
            }

            return maxAverage / k;
        }

    }
}
