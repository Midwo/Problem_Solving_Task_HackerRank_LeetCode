using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_80
    {
        ////(80.) Remove Duplicates from Sorted Array II  (MEDIUM)
        public int RemoveDuplicates(int[] nums)
        {
            int countingTheSameNumbers = 1;
            int lastNumber = nums[0];
            int trueIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                int currValue = nums[i];
                if (currValue == lastNumber)
                {
                    countingTheSameNumbers++;
                    if (countingTheSameNumbers > 2)
                    {
                        continue;
                    }
                    else
                    {
                        trueIndex++;
                        nums[trueIndex] = currValue;
                    }
                }
                else
                {
                    lastNumber = currValue;
                    countingTheSameNumbers = 1;
                    trueIndex++;
                    nums[trueIndex] = currValue;
                }
            }

            return ++trueIndex;
        }
    }
}
