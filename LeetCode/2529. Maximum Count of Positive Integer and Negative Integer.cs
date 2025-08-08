using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2529
    {
        ////(2529.) Maximum Count of Positive Integer and Negative Integer (EASY)
        public int MaximumCount(int[] nums)
        {
            int maxCount = 0;
            int currMaxCountNegative = 0;
            int length = nums.Length;
            int halflength = length / 2;
            int lastI = 0;
            bool posiviteValue = false;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] < 0)
                {
                    currMaxCountNegative++;
                }
                else if (nums[i] == 0)
                {
                    if(currMaxCountNegative > length - currMaxCountNegative - (i - currMaxCountNegative))
                    {
                        return currMaxCountNegative;
                    }
                }
                else
                {
                    if (currMaxCountNegative == 0)
                    {
                        return length - i;
                    }
                    posiviteValue = true;
                    lastI = i;
                    break;
                }
            }

            if (currMaxCountNegative == 0 && posiviteValue == false) 
            {
                return 0;
            }

            maxCount = Math.Max(maxCount, Math.Max(currMaxCountNegative, length-lastI));

            return maxCount;
        }
    }
}
