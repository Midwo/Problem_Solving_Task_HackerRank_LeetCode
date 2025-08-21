using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3146
    {
        ////(3146.) Permutation Difference between Two Strings (EASY)
        public int FindPermutationDifference(string s, string t)
        {
            int[] absValue = new int[26];
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                absValue[s[i] - 'a'] = i;
            }

            for (int i = 0; i < t.Length; i++)
            {
                result += Math.Abs(absValue[t[i] -'a'] - i);
            }

            return result;
        }
    }
}
