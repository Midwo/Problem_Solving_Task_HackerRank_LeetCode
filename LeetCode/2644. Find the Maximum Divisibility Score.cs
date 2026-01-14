using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2644
    {
        ////(2644.) Find the Maximum Divisibility Score (EASY)
        public int MaxDivScore(int[] nums, int[] divisors)
        {
            int MaxCountingCorrectValues = -1;
            int minValueFromMaxCountingCorrectValues = int.MaxValue;
            int numsLength = nums.Length;

            for (int indexDivisors = 0; indexDivisors < divisors.Length; indexDivisors++)
            {
                int currdivisors = divisors[indexDivisors];
                int count = 0;

                for (int indexNums = 0; indexNums < numsLength; indexNums++)
                {
                    if (nums[indexNums] % currdivisors == 0)
                    {
                        count++;
                    }
                }

                if(count > MaxCountingCorrectValues || count == MaxCountingCorrectValues && currdivisors < minValueFromMaxCountingCorrectValues)
                {
                    MaxCountingCorrectValues = count;
                    minValueFromMaxCountingCorrectValues = currdivisors;
                }
            }

            return minValueFromMaxCountingCorrectValues;
        }
    }
}
