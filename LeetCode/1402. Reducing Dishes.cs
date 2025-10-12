using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1402
    {
        ////(1402.) Reducing Dishes (HARD)
        public int MaxSatisfaction(int[] satisfaction)
        {
            int maxSum = int.MinValue;
            Array.Sort(satisfaction);
            int length = satisfaction.Length;

            for (int i = 0; i < length-1; i++)
            {
                int tempValue = satisfaction[i];
                int numberIndex = 2;
                for (int j = i+1; j < length; j++)
                {
                    tempValue += satisfaction[j] * numberIndex++;
                    maxSum = Math.Max(maxSum, tempValue);
                }
            }
            if (maxSum < 0)
            {
                return 0;
            }
            return maxSum;
        }
    }
}
