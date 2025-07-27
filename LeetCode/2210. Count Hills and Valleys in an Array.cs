using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2210
    {
        ////(2210.) Count Hills and Valleys in an Array (EASY)
        public int CountHillValley(int[] nums)
        {
            int sum = 0;
            // 1 up, 2 down, 3 stagnation, -1 no state

            int state = -1;
            int lastValue = nums[0];
            
            for (int i = 1; i < nums.Length; i++)
            {
                if(lastValue > nums[i])
                {
                    if (state == 1)
                    {
                        sum++;
                        state = 2;
                    }
                    else if (state == -1)
                    {
                        state = 2;
                    }
                }
                else if (lastValue < nums[i])
                {
                    if (state == 2)
                    {
                        sum++;
                        state = 1;
                    }
                    else if (state == -1)
                    {
                        state = 1;
                    }                        
                }
                lastValue = nums[i];
            }

            return sum;
        }
    }
}
