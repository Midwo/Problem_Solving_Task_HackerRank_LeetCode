using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_268
    {
        ////(268.) Missing Number (EASY)
        public int MissingNumber(int[] nums)
        {
            int howManyNums = nums.Length;
            int sumIndex = 0;
            int sumNums = 0;

            for (int i = 0; i < howManyNums; i++) 
            {
                sumNums += nums[i];
            }
            for (int i = 0; i <= howManyNums; i++)
            {
                sumIndex += i;
            }
            return sumIndex - sumNums;
        }
    }
}
