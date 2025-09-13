using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1614
    {
        ////(1614.) Maximum Nesting Depth of the Parentheses (EASY)
        public int MaxDepth(string s)
        {
            int maxNestingDepth = 0;

            int countLeft = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    countLeft++;
                }
                else if (s[i] == ')')
                {
                    countLeft--;
                }
                else
                {
                    continue;
                }
                maxNestingDepth = Math.Max(maxNestingDepth, countLeft);
            }

            return maxNestingDepth;
        }
    }
}
