using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3701
    {
        ////(3701.) Compute Alternating Sum (EASY)
        public int AlternatingSum(int[] nums)
        {
            int sum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if(i % 2 == 1)
                {
                    sum -= nums[i];
                }
                else
                {
                    sum += nums[i];
                }
            }

            return sum;
        }
    }
}
