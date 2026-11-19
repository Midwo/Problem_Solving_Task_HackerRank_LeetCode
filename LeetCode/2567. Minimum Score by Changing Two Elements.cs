using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2567
    {
        ////(2567.) Minimum Score by Changing Two Elements (MEDIUM)
        public int MinimizeSum(int[] nums)
        {
            int minScore = int.MaxValue;

            int firstMinValue = int.MaxValue;
            int secondMinValue = int.MaxValue;
            int thirdMinValue = int.MaxValue;

            int firstMaxValue = int.MinValue;
            int secondMaxValue = int.MinValue;
            int thirdMaxValue = int.MinValue;

            for (int index = 0; index < nums.Length; index++)
            {
                int currValue = nums[index];

                if(firstMinValue > currValue)
                {
                    thirdMinValue = secondMinValue;
                    secondMinValue = firstMinValue;
                    firstMinValue = currValue;
                }
                else if (secondMinValue > currValue)
                {
                    thirdMinValue = secondMinValue;
                    secondMinValue = currValue;
                }
                else if (thirdMinValue > currValue)
                {
                    thirdMinValue = currValue;
                }

                if (firstMaxValue < currValue)
                {
                    thirdMaxValue = secondMaxValue;
                    secondMaxValue = firstMaxValue;
                    firstMaxValue = currValue;
                }
                else if (secondMaxValue < currValue)
                {
                    thirdMaxValue = secondMaxValue;
                    secondMaxValue = currValue;
                }
                else if (thirdMaxValue < currValue)
                {
                    thirdMaxValue = currValue;
                }
            }

            //change two min Value to third min

            minScore = Math.Abs(thirdMinValue - firstMaxValue);

            //change two max to third max

            minScore = Math.Min(minScore, (Math.Abs(firstMinValue - thirdMaxValue)));

            //change firstMin to SecondMin and firstMax to SecondMax if firstMin != secondMin && firstMax != SecondMax
            if(firstMinValue != secondMinValue && firstMaxValue != secondMaxValue)
            {
                minScore = Math.Min(minScore, (Math.Abs(secondMinValue - secondMaxValue)));
            }

            return minScore;
        }
    }
}
