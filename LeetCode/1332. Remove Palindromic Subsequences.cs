using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1332
    {
        ////(1332.) Remove Palindromic Subsequences (EASY)
        public int RemovePalindromeSub(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length/2; i++)
            {
                if (s[i] != s[length - 1 - i])
                {
                    return 2;
                }
            }

            return 1;
        }
    }
}
