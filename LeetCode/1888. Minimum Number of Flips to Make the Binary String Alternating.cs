using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1888
    {
        ////(1888.) Minimum Number of Flips to Make the Binary String Alternating (MEDIUM) 
        public int MinFlips(string s)
        {
            int length = s.Length;
            int lenght2x = length * 2;
            char[] patternStart0 = new char[lenght2x];
            char[] patternStart1 = new char[lenght2x];

            s += s;

            for (int i = 0; i < lenght2x; i++)
            {
                patternStart0[i] = (i % 2 == 0) ? '0' : '1';
                patternStart1[i] = (i % 2 == 0) ? '1' : '0';
            }

            int left = 0;
            int diffPattern0 = 0;
            int diffPattern1 = 0;
            int minOperation = int.MaxValue;

            for (int right = 0; right < lenght2x; right++)
            {
                if (s[right] != patternStart0[right]) diffPattern0++;
                if (s[right] != patternStart1[right]) diffPattern1++;

                if (right - left + 1 > length)
                {
                    if (s[left] != patternStart0[left]) diffPattern0--;
                    if (s[left] != patternStart1[left]) diffPattern1--;
                    left++;
                }

                if (right - left +1 == length)
                {
                    minOperation = Math.Min(minOperation, Math.Min(diffPattern0, diffPattern1));
                }
            }

            return minOperation;
        }
    }
}
