using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1413
    {
        ////(1413.) Minimum Value to Get Positive Step by Step Sum (EASY)
        public int MinStartValue(int[] nums)
        {
            int startValue = 1;
            int currSum = 1;

            foreach (int item in nums)
            {
                currSum += item;
                if (currSum < 1)
                {
                    startValue += Math.Abs(currSum - 1);
                    currSum = 1;
                }
            }

            return startValue;
        }
    }
}
