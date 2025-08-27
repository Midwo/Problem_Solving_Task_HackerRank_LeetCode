using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3065
    {
        ////(3065.) Minimum Operations to Exceed Threshold Value I (EASY)
        public int MinOperations(int[] nums, int k)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < k)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
