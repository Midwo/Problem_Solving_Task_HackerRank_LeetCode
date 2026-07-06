using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3708
    {
        ////(3708.) Longest Fibonacci Subarray (MEDIUM)
        public int LongestSubarray(int[] nums)
        {
            ////Solution 1
            int length = nums.Length;

            if (length < 2)
            {
                return 0;
            }

            int maxLength = 2;

            int penultimateValue = nums[0];
            int lastValue = nums[1];
            int currLength = 2;

            for (int indexStart = 2; indexStart < length; indexStart++)
            {
                int currValue = nums[indexStart];

                if (currValue == penultimateValue + lastValue)
                    currLength++;
                else
                    currLength = 2;

                    penultimateValue = lastValue;
                lastValue = currValue;

                maxLength = maxLength < currLength ? currLength : maxLength;
            }

            return maxLength;

            ////Solution 2
            //int length = nums.Length;
            //int maxLength = 2;

            //if(length < 2)
            //{
            //    return 0;
            //}

            //int penultimateValue = 0;
            //int lastValue = nums[0];

            //for (int indexStart = 1; indexStart < length; indexStart++)
            //{  
            //    int currValue = nums[indexStart];
            //    int currLength = 0;

            //    if(currValue == penultimateValue + lastValue)
            //    {
            //        currLength = indexStart > 1 ? 3 : 2;
            //        int inCurrValue = 0;
            //        int inPenultimateValue = lastValue;
            //        int inLastValue = currValue;

            //        for (int inIndex = indexStart+1; inIndex < length; inIndex++)
            //        {
            //            inCurrValue = nums[inIndex];
            //            if (inCurrValue == inPenultimateValue + inLastValue)
            //            {
            //                currLength++;
            //                inPenultimateValue = inLastValue;
            //                inLastValue = inCurrValue;
            //            }
            //            else
            //                break;        
            //        }

            //    }

            //    penultimateValue = lastValue;
            //    lastValue = currValue;

            //    maxLength = maxLength < currLength ? currLength : maxLength;
            //}

            //return maxLength;
        }
    }
}
