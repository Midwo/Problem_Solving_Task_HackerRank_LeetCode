using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_561
    {
        ////(561.) Array Partition (EASY)
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int result = 0;
            while(i < nums.Length)
            {
                result += nums[i];
                i += 2;
            }
            return result;
        }
    }
}
