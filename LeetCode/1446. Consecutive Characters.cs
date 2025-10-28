using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1446
    {
        ////(1446.) Consecutive Characters (EASY)
        public int MaxPower(string s)
        {
            int maxCount = 1;
            char lastChar = s[0];
            int currCount = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == lastChar)
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                    lastChar = s[i];
                }
                maxCount = currCount > maxCount ? currCount : maxCount;
            }

            return maxCount;
        }
    }
}
