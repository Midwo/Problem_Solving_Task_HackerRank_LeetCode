using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_153
    {
        ////(153.) Find Minimum in Rotated Sorted Array (MEDIUM)
        public int FindMin(int[] nums)
        {
            ////Solution 1
            int left = 0;
            int right = nums.Length - 1;

            while (left != right) 
            { 
                int mid = (left + right) / 2;
                if (nums[left] > nums[mid])
                {
                    right = mid;
                }
                else if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right--;
                }
            }

            return nums[left];

            ////Solution 2
            //return nums.Min();
        }
    }
}
