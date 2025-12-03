using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1848
    {
        ////(1848.) Minimum Distance to the Target Element (EASY)
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int minDistance = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    int currDistance =  Math.Abs(i - start);
                    minDistance = minDistance > currDistance? currDistance : minDistance;
                }
            }

            return minDistance;
        }
    }
}
