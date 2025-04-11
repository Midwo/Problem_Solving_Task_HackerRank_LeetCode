using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_747
    {
        ////747.Largest Number At Least Twice of Others
        public int DominantIndex(int[] nums)
        {
            int indexHighestNumber = int.MinValue;
            int highestNumber = int.MinValue;
            int secondHighestNumber = int.MinValue;
            bool newFoundMax = false;

            for (int i = 0; i < nums.Length; i++)
            {
                newFoundMax = false;
                if (highestNumber < nums[i])
                {   
                    if (secondHighestNumber < highestNumber)
                    {
                        secondHighestNumber = highestNumber;
                    }
                    highestNumber = nums[i];
                    indexHighestNumber = i;
                    newFoundMax = true;
                }
                if (secondHighestNumber < nums[i] && newFoundMax == false)
                {
                    secondHighestNumber = nums[i];
                }
            }
            if (secondHighestNumber >= int.MinValue && highestNumber >= int.MinValue && secondHighestNumber*2 <= highestNumber)
            {
                return indexHighestNumber;
            }
            else
            {
                return -1;
            }
        }
    }
}
