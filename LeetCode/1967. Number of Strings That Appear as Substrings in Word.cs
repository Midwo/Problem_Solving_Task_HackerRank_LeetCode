using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1967
    {
        ////(1967.) Number of Strings That Appear as Substrings in Word (EASY)
        public int NumOfStrings(string[] patterns, string word)
        {
            ////0ms, Beats: 100.00% 

            int count = 0;
            
            for (int i = 0; i < patterns.Length; i++)
            {
                if (word.Contains(patterns[i]))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
