using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1991
    {
        ////(1991.) Find the Middle Index in Array (EASY)
        public int FindMiddleIndex(int[] nums)
        {
            int length = nums.Length;
            if (length == 1)
            {
                return 0;
            }
            int[] leftSumTable = new int[nums.Length];
            int[] RightSumTable = new int[nums.Length];


            leftSumTable[0] = nums[0];
            RightSumTable[length-1] = nums[length-1];

            for (int i = 1; i < nums.Length; i++) 
            {
                leftSumTable[i] = nums[i] + leftSumTable[i-1];
                RightSumTable[length - i - 1] = nums[length - 1 - i] + RightSumTable[length - i];
            }

            if (RightSumTable[1] == 0)
            {
                return 0;
            }

            for (int i = 1; i < length - 1; i++)
            {
                int currValue = leftSumTable[i - 1];
                if (currValue == RightSumTable[i + 1])
                {
                    return i;
                }
            }

            if (leftSumTable[length-2] == 0)
            {
                return length - 1;
            }
            return -1;
        }
    }
}
