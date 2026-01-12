using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3379
    {
        ////(3379.) Transformed Array (EASY)
        public int[] ConstructTransformedArray(int[] nums)
        {
            int length = nums.Length;

            int[] newTable = new int[length];

            for (int indexNums = 0; indexNums < length; indexNums++) 
            { 
                int realStepsPlusIndex = nums[indexNums] % length;
                if (realStepsPlusIndex > 0)
                {
                    realStepsPlusIndex += indexNums;
                    if (realStepsPlusIndex > length - 1)
                    {
                        newTable[indexNums] = nums[realStepsPlusIndex - length];
                    }
                    else
                    {
                        newTable[indexNums] = nums[realStepsPlusIndex];
                    }
                }
                else
                {
                    realStepsPlusIndex += indexNums;
                    if(realStepsPlusIndex >= 0)
                    {
                        newTable[indexNums] = nums[realStepsPlusIndex];
                    }
                    else
                    {
                        newTable[indexNums] = nums[length + realStepsPlusIndex];
                    }
                }
            }
            return newTable;
        }
    }
}
