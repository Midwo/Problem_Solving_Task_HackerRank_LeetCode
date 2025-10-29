using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3158
    {
        ////(3158.) Find the XOR of Numbers Which Appear Twice (EASY)
        public int DuplicateNumbersXOR(int[] nums)
        {
            ////0ms, Beats: 100.00%

            int[] countNums = new int[51];
            int resultXOR = 0;

            foreach (int num in nums)
            {
                countNums[num]++;
            }
            
            for(int i = 1; i < 51; i++)
            {
                if (countNums[i] == 2)
                {
                    resultXOR ^= i;
                }
            }

            return resultXOR;
        }
    }
}
