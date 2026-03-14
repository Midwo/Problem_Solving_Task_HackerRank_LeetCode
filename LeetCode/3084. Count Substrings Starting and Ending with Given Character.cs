using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3084
    {
        ////(3084.) Count Substrings Starting and Ending with Given Character (MEDIUM)
        public long CountSubstrings(string s, char c)
        {
            long result = 0;
            long countTargetChar = 0;

            foreach (char currChar in s)
            {
                if (currChar == c)
                {
                    countTargetChar++;
                }
            }

            result = (countTargetChar + 1) * countTargetChar / 2;

            return result;
        }
    }
}
