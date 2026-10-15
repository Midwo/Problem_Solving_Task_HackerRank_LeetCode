using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3833
    {
        ////(3833.) Count Dominant Indices (EASY)
        public int DominantIndices(int[] nums)
        {
            int sum = nums[nums.Length-1];
            int count = 1;
            int countDominantIdices = 0;

            for(int index = nums.Length-2; index >= 0; index--)
            {
                int currValue = nums[index];
                int avg = sum / count;

                if (currValue > avg)
                    countDominantIdices++;

                sum += currValue;
                count++;
            }


            return countDominantIdices;
        }
    }
}
