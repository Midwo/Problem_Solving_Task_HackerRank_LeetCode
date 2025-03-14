using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_11
    {
        ////(11.) Container With Most Water (MEDIUM)
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int howManyValues = height.Length;
            int left = 0;
            int right = height.Length-1;

            while(left < right)
            {
                int currArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
