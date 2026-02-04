using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1624
    {
        ////(1624.) Largest Substring Between Two Equal Characters (EASY)
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            int[] indexFirstChar = new int[26];
            int maxLengthBetween = -1;

            for (int i = 0; i < s.Length; i++)
            {
                char currChar = s[i];
                if (indexFirstChar[currChar-'a'] > 0)
                {
                    maxLengthBetween = Math.Max(maxLengthBetween, i - indexFirstChar[currChar - 'a']);
                }
                else
                {
                    indexFirstChar[currChar - 'a'] = i+1;
                }
            }

            return maxLengthBetween;
        }
    }
}
