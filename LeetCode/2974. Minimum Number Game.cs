using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2974
    {
        ////(2974.) Minimum Number Game (EASY)
        public int[] NumberGame(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i +=2)
            {
                int temp = nums[i - 1];
                nums[i-1] = nums[i];
                nums[i] = temp;
            }

            return nums;
        }
    }
}
