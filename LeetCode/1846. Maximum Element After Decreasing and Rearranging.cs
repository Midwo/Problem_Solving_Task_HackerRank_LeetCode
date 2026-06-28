using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1846
    {
        ////(1846.) Maximum Element After Decreasing and Rearranging (MEDIUM)
        public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
        {
            int maxLength = 1;
            int length = arr.Length;
            int countDismiss = 0;
            Array.Sort(arr);

            for (int index = 1; index < length; index++)
            {
                int currArrValue = arr[index];
                if (maxLength < currArrValue)
                {
                    if(currArrValue >= length - 1 || currArrValue + countDismiss >= length - 1)
                    {
                        return length - countDismiss;
                    }
                    else
                    {
                        int diffIndex = currArrValue - maxLength;
                        maxLength += diffIndex;
                        index += diffIndex - 1;
                    }
                }
                else
                {
                    countDismiss++;
                }
            }

            return maxLength;
        }
    }
}
