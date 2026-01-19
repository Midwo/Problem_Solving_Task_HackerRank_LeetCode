using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3707
    {
        ////(3707.) Equal Score Substrings (EASY)
        public bool ScoreBalance(string s)
        {
            bool statusBalance = false;
            int length = s.Length;

            int[] dpRightSum = new int[length];
            int currSumDP = 0;
            for (int i = length -1; i > -1; i--)
            {
                currSumDP += s[i] -'a' +1;
                dpRightSum[i] = currSumDP;
            }

            int currSumLeft = 0;

            for(int i = 0; i < length-1; i++)
            {
                currSumLeft += s[i] - 'a' + 1;
                if (currSumLeft == dpRightSum[i + 1])
                {
                    return true;
                }
            }

            return statusBalance;
        }
    }
}
