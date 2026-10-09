using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3852
    {
        ////(3852.) Smallest Pair With Different Frequencies (EASY)
        public int[] MinDistinctFreqPair(int[] nums)
        {
            int[] freq = new int[101];

            foreach (int num in nums)
            {
                freq[num]++;
            }

            bool nextValueStatus = false;
            int freqfirstValue = 0;
            int firstValue = 0;

            for (int value = 1; value < 101; value++)
            {
                int currFreq = freq[value];
                if(currFreq > 0 && nextValueStatus == false)
                {
                    firstValue = value;
                    freqfirstValue = currFreq;
                    nextValueStatus = true;
                }
                else if (currFreq > 0 && currFreq != freqfirstValue)
                {
                    return new int[2] { firstValue, value };
                }
            }

            return new int[2] { -1, -1 };
        }
    }
}
