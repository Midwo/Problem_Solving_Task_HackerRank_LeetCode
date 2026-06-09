using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3689
    {
        ////(3689.) Maximum Total Subarray Value I (MEDIUM)
        public long MaxTotalValue(int[] nums, int k)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int x in nums) 
            {
                min = min > x ? x : min;
                max = max < x ? x : max;
            }

            return (long)(max - min) * k;
        }
    }
}
