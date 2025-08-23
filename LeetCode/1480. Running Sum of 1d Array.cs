using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1480
    {
        ////(1480.) Running Sum of 1d Array (EASY)
        public int[] RunningSum(int[] nums)
        {
            int currValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {   
                currValue = currValue + nums[i];
                nums[i] = currValue;
            }
            return nums;
        }
    }
}
