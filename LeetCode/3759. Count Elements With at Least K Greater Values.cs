using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3759
    {
        ////(3759.) Count Elements With at Least K Greater Values (MEDIUM)
        public int CountElements(int[] nums, int k)
        {
            int length = nums.Length;
            if (k == 0)
            {
                return nums.Length;
            }

            int counter = 1;
            Array.Sort(nums);

            for (int index = length-2; index >= 0; index--) 
            {
                if(counter >= k)
                {
                    if(nums[index] != nums[index + 1])
                    {
                        return index+1;
                    }
                }
                counter++;
            }

            return 0;
        }
    }
}
