using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2221
    {
        ////(2221.) Find Triangular Sum of an Array (MEDIUM)
        public int TriangularSum(int[] nums)
        {
            ////31ms, Beats: 92.86%
            int lengthJ = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < lengthJ; j++)
                {
                    nums[j] = (nums[j] + nums[j + 1]) % 10;
                }
                lengthJ--;
            }

            return nums[0];
        }
    }
}
