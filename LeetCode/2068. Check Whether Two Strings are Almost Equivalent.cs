using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2068
    {
        ////(2068.) Check Whether Two Strings are Almost Equivalent (EASY)
        public bool CheckAlmostEquivalent(string word1, string word2)
        {
            int[] charDiff = new int[26];

            for (int i = 0; i < word1.Length; i++) 
            {
                charDiff[word1[i] - 'a']++;
                charDiff[word2[i] - 'a']--;
            }

            foreach (int freq in charDiff)
            {
                if (freq > 3 || freq < -3)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
