using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_704
    {
        ////(704.) Binary Search (EASY)

        public int Search(int[] nums, int target)
        {
            int length = nums.Length;
            int left = 0;
            int right = length-1;

            while (left < right) 
            {
                int targetIndex = left + (right - left) / 2;
                if (target > nums[targetIndex])
                {
                    left = targetIndex+1;
                }
                else
                {
                    right = targetIndex;
                }                
            }
            if (nums[left] == target)
            {
                return left;
            }
            return -1;

        }

    }
}
