using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_154
    {
        ////(154.) Find Minimum in Rotated Sorted Array II (HARD)
        public int FindMin(int[] nums)
        {
            int l = 0;
            int r = nums.Length - 1;

            while (l != r) 
            {
                int mid = (r + l) / 2;
                if (nums[l] > nums[mid])
                {
                    r = mid;
                } 
                else if (nums[mid] > nums[r])
                {
                    l = mid+1;
                }
                else
                {
                    r--;
                }            
            }

            return nums[l];
        }
    }
}
