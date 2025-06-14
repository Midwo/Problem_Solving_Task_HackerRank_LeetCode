using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2616
    {
        ////(2616.) Minimize the Maximum Difference of Pairs (MEDIUM)
        public int MinimizeMax(int[] nums, int p)
        {
            Array.Sort(nums);

            int lengthNums = nums.Length;

            int left = 0;
            int right = nums[lengthNums - 1] - nums[0];

            while (left < right) 
            { 
                int middle = left + (right - left) / 2;
                
                if (countValidPairs(nums, middle, lengthNums) >= p)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return left;

        }
        
        private int countValidPairs(int[] nums, int middle, int lengthNums)
        {
            int count = 0;
            int i = 0;

            while (i < lengthNums - 1)
            {
                if (nums[i + 1] - nums[i] <= middle)
                {
                    count++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            return count;
        }
    }
}
