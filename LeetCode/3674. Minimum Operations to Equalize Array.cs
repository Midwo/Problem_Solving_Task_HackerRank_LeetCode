using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3674
    {
        ////(3674.) Minimum Operations to Equalize Array (EASY)
        public int MinOperations(int[] nums)
        {
            int first = nums[0];

            for (int i = 1; i < nums.Length; i++) 
            {
                if (nums[i] != first)
                    return 1;
            }

            return 0;
        }
    }
}
