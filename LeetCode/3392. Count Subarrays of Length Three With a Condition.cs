using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3392
    {
        ////(3392.) Count Subarrays of Length Three With a Condition (EASY)
        public int CountSubarrays(int[] nums)
        {
            int count = 0;
            int length = nums.Length;
            for (int i = 1; i< length-1; i++)
            {
                if ((nums[i-1] + nums[i +1])*2 == nums[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
