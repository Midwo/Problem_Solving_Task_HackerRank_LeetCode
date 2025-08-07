using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3467
    {
        ////(3467.) Transform Array by Parity (EASY)
        public int[] TransformArray(int[] nums)
        {
            for (int i = 0; i<nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 0;
                }
            }

            Array.Sort(nums);   

            return nums;
        }
    }
}
