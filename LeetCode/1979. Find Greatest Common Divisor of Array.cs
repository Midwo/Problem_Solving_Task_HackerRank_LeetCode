using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1979
    {
        ////(1979.) Find Greatest Common Divisor of Array (EASY)
        public int FindGCD(int[] nums)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            
            for (int i = 0; i < nums.Length; i++) 
            { 
                min = nums[i] < min? nums[i] : min;
                max = nums[i] > max? nums[i] : max;
            }
            
            if (min == max)
            {
                return min;
            }

            for (int i = min; i >= 1; i--)
            {
                if (min % i == 0 & max % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
