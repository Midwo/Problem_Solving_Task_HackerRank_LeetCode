using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3005
    {
        ////(3005.) Count Elements With Maximum Frequency (EASY)
        public int MaxFrequencyElements(int[] nums)
        {
            ////1ms, Beats: 95.96%

            int[] countValue = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                countValue[nums[i]]++;
            }

            int maxfrequency = 0;
            int sumCount = 0;

            for (int i = 0; i < countValue.Length; i++)
            {
                if (countValue[i] > maxfrequency)
                {
                    maxfrequency = countValue[i];
                    sumCount = maxfrequency;
                }
                else if (countValue[i] == maxfrequency)
                {
                    sumCount += countValue[i];
                }
            }

            return sumCount;
        }
    }
}
