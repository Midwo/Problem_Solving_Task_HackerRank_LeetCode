using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3866
    {
        ////(3866.) First Unique Even Element (EASY)
        public int FirstUniqueEven(int[] nums)
        {
            int[] countNum = new int[101];

            foreach (int num in nums)
            {
                countNum[num]++;
            }
            
            for(int index = 0; index < nums.Length; index++)
            {
                if(countNum[nums[index]] == 1 && nums[index] % 2 == 0)
                {
                    return nums[index];
                }
            }

            return -1;
        }
    }
}
