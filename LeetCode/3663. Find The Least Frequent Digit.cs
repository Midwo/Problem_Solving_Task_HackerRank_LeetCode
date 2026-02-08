using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3663
    {
        ////(3663.) Find The Least Frequent Digit (EASY)
        public int GetLeastFrequentDigit(int n)
        {
            int[] freqNumbers = new int[10];

            while(n > 0)
            {
                freqNumbers[n % 10]++;
                n /= 10;
            }

            int minFreq = int.MaxValue;
            int minValueFreq = int.MaxValue;

            for (int i = 0; i < 10; i++) 
            {
                if (freqNumbers[i] < minFreq && freqNumbers[i] > 0)
                {
                    minValueFreq = i;
                    minFreq = freqNumbers[i];
                }
            }

            return minValueFreq;
        }
    }
}
