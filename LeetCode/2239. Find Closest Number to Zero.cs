using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2239
    {
        ////(2239.) Find Closest Number to Zero (EASY)
        public int FindClosestNumber(int[] nums)
        {
            int closestValueToZero = int.MaxValue;
            int maxNoABSValue = int.MinValue;

            for (int indexNums = 0; indexNums < nums.Length; indexNums++)
            {
                int currValue = nums[indexNums];
                int currABSValue = currValue < 0 ? -currValue : currValue;

                if(currABSValue < closestValueToZero || closestValueToZero == currABSValue && currValue > maxNoABSValue)
                {
                    closestValueToZero = currABSValue;
                    maxNoABSValue = currValue;
                }
            }

            return maxNoABSValue;
        }
    }
}
