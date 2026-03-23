using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2090
    {
        ////(2090.) K Radius Subarray Averages (MEDIUM)
        public int[] GetAverages(int[] nums, int k)
        {
            long sum = 0;
            int length = nums.Length;
            int[] resultTable = new int[length];

            if(k == 0)
            {
                return nums;
            }

            int divider = k + k + 1;

            if(divider > length)
            {
                for (int i = 0; i < length; i++)
                {
                    resultTable[i] = -1;
                }
                return resultTable;
            }

            for (int i = 0; i < k; i++)
            {
                sum += nums[i] + nums[k + i];
                resultTable[i] = -1;
                resultTable[length - 1 - i] = -1;
            }

            sum += nums[k + k];
            resultTable[k] = (int)(sum / divider);

            for (int i = divider; i < length; i++)
            {
                sum += nums[i] - nums[i-divider];
                resultTable[i-k] = (int)(sum / divider);
            }

            return resultTable;
        }
    }
}
