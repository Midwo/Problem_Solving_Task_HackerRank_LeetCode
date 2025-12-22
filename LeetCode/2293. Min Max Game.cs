using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2293
    {
        ////(2293.) Min Max Game (EASY)
        public int MinMaxGame(int[] nums)
        {
            int index = 0;
            int length = nums.Length;
            
            for (int i = 0; i < length-1; i += 2)
            {
                if(index % 2 == 0)
                {
                    nums[index] = Math.Min(nums[i], nums[i + 1]);
                }
                else
                {
                    nums[index] = Math.Max(nums[i], nums[i + 1]);
                }
                index++;

                if(i == length - 2)
                {
                    length /= 2;
                    i = -2;
                    index = 0;
                }
            }
            
            return nums[0];
        }
    }
}
