using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1920
    {
        ////(1920.) Build Array from Permutation (EASY)
        public int[] BuildArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }

            return result;
        }
    }
}
