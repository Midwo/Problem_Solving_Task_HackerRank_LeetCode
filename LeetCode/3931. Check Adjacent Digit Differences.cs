using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3931
    {
        ////(3931.) Check Adjacent Digit Differences (EASY)
        public bool IsAdjacentDiffAtMostTwo(string s)
        {
            int lastValue = s[0]-'0';
            int currValue;

            for (int i = 0; i < s.Length; i++)
            {
                currValue = s[i] - '0';

                if (Math.Abs(currValue - lastValue) > 2)
                    return false;

                lastValue = currValue;
            }

            return true;
        }
    }
}
