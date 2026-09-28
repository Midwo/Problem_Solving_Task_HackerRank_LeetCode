using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3745
    {
        ////(3745.) Maximize Expression of Three Elements (EASY)
        public int MaximizeExpressionOfThree(int[] nums)
        {
            int maxValue = int.MinValue;
            int secondMaxValue = int.MaxValue;
            int minValue = int.MaxValue;

            foreach (int num in nums) 
            {
                if (num > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = num;
                }
                else if (num == maxValue)
                {
                    secondMaxValue = num;
                }
                else if (num > secondMaxValue)
                {
                    secondMaxValue = num;
                }
                minValue = num < minValue? num : minValue; 
            }

            return maxValue + secondMaxValue - minValue;
        }
    }
}
