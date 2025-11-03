using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1578
    {
        ////(1578.) Minimum Time to Make Rope Colorful (MEDIUM)
        public int MinCost(string colors, int[] neededTime)
        {
            int result = 0;
            int currSum = 0;
            char lastChar = '/';
            int currMax = 0;

            for (int i = 0; i < colors.Length; i++)
            {
                char tempChar = colors[i];
                if(lastChar != tempChar)
                {
                    if (currSum != currMax)
                    {
                        result += currSum - currMax;
                    }
                    currSum = neededTime[i];
                    currMax = neededTime[i];
                    lastChar = tempChar;
                }
                else
                {
                    currSum += neededTime[i];
                    if (neededTime[i] > currMax)
                    {
                        currMax = neededTime[i];
                    }
                }
            }
            if (currSum != currMax)
            {
                result += currSum - currMax;
            }
            return result;
        }
    }
}
