using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2341
    {
        ////(2341.) Maximum Number of Pairs in Array (EASY)
        public int[] NumberOfPairs(int[] nums)
        {
            int[] countNums = new int[101];
            int pairs = 0;
            int noPairs = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                countNums[nums[i]]++;
            }

            for (int i = 0; i < 101; i++)
            {
                if (countNums[i] > 0)
                {
                    if (countNums[i] % 2 != 0)
                    {
                        noPairs++;
                    }
                    pairs += countNums[i] / 2;
                }
            }

            return new int[] { pairs, noPairs };
        }
    }
}
