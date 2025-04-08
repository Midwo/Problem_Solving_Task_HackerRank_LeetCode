using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_724
    {
        ////(724.) Find Pivot Index (EASY)
        public int PivotIndex(int[] nums)
        {
            int sumNums = 0;
            foreach (int num in nums) 
            {
                sumNums += num;
            }
            int sumLeft = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sumNums -= nums[i]; 
                if (sumLeft == sumNums)
                {
                    return i;
                }
                sumLeft += nums[i];
            }

            return -1;
        }
    }
}
