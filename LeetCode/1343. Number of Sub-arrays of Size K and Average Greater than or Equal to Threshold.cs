using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1343
    {
        ////(1343.) Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold (MEDIUM)
        public int NumOfSubarrays(int[] arr, int k, int threshold)
        {
            int currThreshold = 0;
            int countCurrThresholdGreaterOrEqualToOryginalThreshold = 0;
            int length = arr.Length;
            int minSum = k * threshold;

            for (int i = 0; i < k; i++)
            {
                currThreshold += arr[i];
            }

            if (currThreshold >= minSum)
            {
                countCurrThresholdGreaterOrEqualToOryginalThreshold++;
            }

            for (int i = k; i < length; i++)
            {
                currThreshold += arr[i] - arr[i - k];
                if (currThreshold >= minSum)
                {
                    countCurrThresholdGreaterOrEqualToOryginalThreshold++;
                }
            }

            return countCurrThresholdGreaterOrEqualToOryginalThreshold;
        }
    }
}
