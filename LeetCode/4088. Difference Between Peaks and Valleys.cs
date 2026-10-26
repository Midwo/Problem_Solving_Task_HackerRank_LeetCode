using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4088
    {
        ////(4088.) Difference Between Peaks and Valleys (EASY)
        public int PeakValleyDifference(int[] nums)
        {
            int beforeMidValue = -1;
            int middleValue = nums[0];
            int afterMidValue = nums[1];
            int diffBetweenPeaksValleys = 0;

            for (int i = 2; i < nums.Length; i++) 
            {
                beforeMidValue = middleValue;
                middleValue = afterMidValue;
                afterMidValue = nums[i];

                if (middleValue > beforeMidValue && middleValue > afterMidValue)
                    diffBetweenPeaksValleys += middleValue;
                else if(middleValue < beforeMidValue && middleValue < afterMidValue)
                    diffBetweenPeaksValleys -= middleValue;
            }

            return diffBetweenPeaksValleys;
        }
    }
}
