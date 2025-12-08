using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2460
    {
        ////(2460.) Apply Operations to an Array (EASY)
        public int[] ApplyOperations(int[] nums)
        {
            int[] newNums = new int[nums.Length];
            int indexNewNums = 0;

            for (int i = 1; i < nums.Length; i++) 
            {
                if (nums[i-1] == nums[i])
                {
                    nums[i] = 0;
                    nums[i - 1] = nums[i - 1] * 2;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    newNums[indexNewNums++] = nums[i];
                }            
            }

            return newNums;
        }
    }
}
