using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2873
    {
        ////(2873.) Maximum Value of an Ordered Triplet I (EASY)
        public long MaximumTripletValue(int[] nums)
        {
            long maxScore = 0;
            long currScore = 0;
            int length = nums.Length;
            int firstValue = 0;
            long firstMinusSecondValue = 0;

            for (int i = 0; i < length - 2; i++)
            {
                firstValue = nums[i];
                for (int j = i + 1; j < length - 1; j++)
                {
                    firstMinusSecondValue = firstValue - nums[j];
                    if (firstMinusSecondValue > 0)
                    {
                        for (int k = j + 1; k < length; k++)
                        {
                            currScore = firstMinusSecondValue * nums[k];
                            maxScore = maxScore < currScore? currScore : maxScore;
                        }
                    }
                }
            }

            return maxScore;
        }
    }
}
