using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3925
    {
        ////(3925.) Concatenate Array With Reverse (EASY)
        public int[] ConcatWithReverse(int[] nums)
        {
            int lengthNums = nums.Length;
            int lengthResultTable = lengthNums + lengthNums;
            int[] resultConcatTable = new int[lengthResultTable];

            for (int i = 0; i < lengthNums; i++)
            {
                resultConcatTable[i] = nums[i];
                resultConcatTable[lengthResultTable - 1 - i] = nums[i];
            }

            return resultConcatTable;
        }
    }
}
