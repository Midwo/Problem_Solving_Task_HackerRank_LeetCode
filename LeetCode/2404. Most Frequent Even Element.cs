using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2404
    {
        ////(2404.) Most Frequent Even Element (EASY)
        public int MostFrequentEven(int[] nums)
        {
            int maxFreq = 0;
            int minValueMaxFreq = int.MaxValue;
            int[] countNums = new int[100001];
            int currValue = 0;
            int currFreq = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currValue = nums[i];
                if ((currValue & 1) == 0)
                {
                    countNums[currValue]++;
                    currFreq = countNums[currValue];
                    if (currFreq > maxFreq || currFreq == maxFreq && currValue < minValueMaxFreq)
                    {
                        maxFreq = currFreq;
                        minValueMaxFreq = currValue;
                    }
                }
            }

            if (minValueMaxFreq == int.MaxValue)
            {
                return -1;
            }

            return minValueMaxFreq;
        }
    }
}
