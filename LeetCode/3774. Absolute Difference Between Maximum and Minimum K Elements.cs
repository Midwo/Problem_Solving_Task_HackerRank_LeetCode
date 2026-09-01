using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3774
    {
        ////(3774.) Absolute Difference Between Maximum and Minimum K Elements (EASY)
        public int AbsDifference(int[] nums, int k)
        {
            int lenght = nums.Length;

            Array.Sort(nums);

            int absDifference = 0;

            for (int index = 0; index < k; index++) 
            {
                absDifference += nums[lenght-1-index] - nums[index];
            }

            return absDifference;
        }
    }
}
