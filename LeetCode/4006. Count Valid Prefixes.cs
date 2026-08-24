using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4006
    {
        ////(4006.) Count Valid Prefixes (EASY)
        public int CountValidPrefixes(string s)
        {
            int countValidPrefixes = 0;
            int diff = 0;

            for (int index = 0; index < s.Length; index++)
            {
                diff += s[index] == '1' ? 1 : -1;
                if (diff == 1 || diff == -1 || diff == 0)
                    countValidPrefixes++;
            }

            return countValidPrefixes;
        }
    }
}
