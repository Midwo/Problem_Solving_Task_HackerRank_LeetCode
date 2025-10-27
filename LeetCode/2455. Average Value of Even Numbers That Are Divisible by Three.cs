using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2455
    {
        ////(2455.) Average Value of Even Numbers That Are Divisible by Three (EASY)
        public int AverageValue(int[] nums)
        { 
            int count = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] %2 == 0 && nums[i] % 3 == 0)
                {
                    count++;
                    sum += nums[i];
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        }
    }
}
