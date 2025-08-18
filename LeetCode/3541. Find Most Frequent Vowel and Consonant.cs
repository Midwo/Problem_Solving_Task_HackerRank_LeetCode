using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3541
    {
        ////(3541.) Find Most Frequent Vowel and Consonant (EASY)
        public int MaxFreqSum(string s)
        {
            int[] charsList = new int[26];

            int maxVowelsFrequency = 0;
            int maxConsonantsFrequency = 0;

            for (int i = 0; i < s.Length; i++)
            {
                charsList[s[i] - 97] += 1;
            }


            for (int i = 0; i < charsList.Length; i++)
            {
                if (i == 0 || i == 4 || i == 8 || i == 14 || i == 20)
                {
                    maxVowelsFrequency = Math.Max(maxVowelsFrequency, charsList[i]);
                }
                else
                {
                    maxConsonantsFrequency = Math.Max(maxConsonantsFrequency, charsList[i]);
                }
            }

            return maxConsonantsFrequency + maxVowelsFrequency;

        }
    }
}
