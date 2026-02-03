using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1742
    {
        ////(1742.) Maximum Number of Balls in a Box (EASY)
        public int CountBalls(int lowLimit, int highLimit)
        {
            int[] countBalls = new int[46];

            for (int i = lowLimit; i <= highLimit; i++)
            {
                int currValue = i;
                int currSum = 0;
                while (currValue != 0)
                {
                    int temp = currValue % 10;
                    currSum += temp;
                    currValue /= 10;
                }
                countBalls[currSum]++;
            }

            int maxBalls = 0;

            for (int i = 1; i < countBalls.Length; i++)
            {
                maxBalls = maxBalls < countBalls[i]? countBalls[i] : maxBalls;
            }

            return maxBalls;
        }
    }
}
