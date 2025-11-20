using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3038
    {
        ////(3038.) Maximum Number of Operations With the Same Score I (EASY)
        public int MaxOperations(int[] nums)
        {
            int count = 1;
            int sum = nums[0] + nums[1];

            for (int i = 2; i < nums.Length-1; i += 2) 
            { 
                if (sum == nums[i] + nums[i+1])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
