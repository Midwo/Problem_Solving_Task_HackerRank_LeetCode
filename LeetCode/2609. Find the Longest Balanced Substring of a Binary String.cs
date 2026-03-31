using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2609
    {
        ////(2609.) Find the Longest Balanced Substring of a Binary String (EASY)
        public int FindTheLongestBalancedSubstring(string s)
        {
            int currCountZero = 0;
            int currCountOne = 0;
            bool resetZero = false;
            int maxBalancedLenght = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    if (resetZero)
                    {
                        currCountZero = 0;
                        resetZero = false;
                        currCountOne = 0;
                    }
                    currCountZero++;
                }
                else
                {
                    currCountOne++;
                    resetZero = true;
                    maxBalancedLenght = Math.Max(maxBalancedLenght, Math.Min(currCountZero, currCountOne)*2);
                }
            }

            return maxBalancedLenght;
        }
    }
}
