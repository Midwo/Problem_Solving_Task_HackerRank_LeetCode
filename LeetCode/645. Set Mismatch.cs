using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_645
    {
        ////(645.) Set Mismatch (EASY)
        public int[] FindErrorNums(int[] nums)
        {
            
            int resultDuplicate = 0;
            
            foreach (int num in nums) 
            {
                if (nums[Math.Abs(num) -1] < 0)
                {
                    resultDuplicate = Math.Abs(num);
                }
                else
                {
                    nums[Math.Abs(num) - 1] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    return new int[] {resultDuplicate, i+1 };
                }
            }
            return new int[] {};

        }
    }
}
