using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_628
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int legth = nums.Length;
            
            int value1 = nums[0];
            int value2 = nums[1];
            int value3 = nums[legth - 1];
            if (legth > 3)
            {
                if(value3 >= 0)
                {
                    if (Math.Abs(value2) + Math.Abs(value1) > nums[legth - 3] + nums[legth - 2])
                    {
                        return Math.Abs(value2) * Math.Abs(value1) * value3;
                    }
                    else
                    {
                        return nums[legth - 1]*nums[legth - 2]*nums[legth - 3];
                    }
                }
                else
                {
                    return nums[legth-1]*nums[legth-2]*nums[legth-3];
                }
            }
            else
            {
                return value1 * value2 * value3;
            }
        }
    }
}
