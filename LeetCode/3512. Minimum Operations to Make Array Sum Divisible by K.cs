using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3512
    {
        ////(3512.) Minimum Operations to Make Array Sum Divisible by K (EASY)
        public int MinOperations(int[] nums, int k)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int temp = sum % k;

            if (temp != 0)
            {
                return temp;
            }

            return 0;
        }

    }
}
