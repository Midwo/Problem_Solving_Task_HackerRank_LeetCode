using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3880
    {
        ////(3880.) Minimum Absolute Difference Between Two Values (EASY)
        public int MinAbsoluteDifference(int[] nums)
        {
            int lastIndexOne = -1;
            int lastIndexTwo = -1;
            int minAbsoluteDiff = int.MaxValue;

            for(int index = 0; index < nums.Length; index++)
            {
                int currValue = nums[index];

                if(currValue == 1)
                {
                    if (lastIndexTwo != -1)
                        minAbsoluteDiff = Math.Min(index - lastIndexTwo, minAbsoluteDiff);
                    lastIndexOne = index;
                }
                else if (currValue == 2)
                {
                    if(lastIndexOne != -1)
                        minAbsoluteDiff = Math.Min(index - lastIndexOne, minAbsoluteDiff);
                    lastIndexTwo = index;
                }

                if (minAbsoluteDiff == 1)
                    return 1;
            }

            if (lastIndexOne == -1 || lastIndexTwo == -1)
                return -1;
            return minAbsoluteDiff;
        }
    }
}
