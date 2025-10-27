using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2778
    {
        ////(2778.) Sum of Squares of Special Elements (EASY)
        public int SumOfSquares(int[] nums)
        {
            ////0ms, Beats: 100.00%
            
            int sum = 0;
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (length % (i+1) == 0)
                {
                    sum += nums[i] * nums[i];
                }
            }

            return sum;
        }
    }
}
