using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1464
    {
        ////(1464.) Maximum Product of Two Elements in an Array (EASY)
        public int MaxProduct(int[] nums)
        {
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > secondMax)
                {
                    if (nums[i] > firstMax)
                    {
                        secondMax = firstMax;
                        firstMax = nums[i];
                    }
                    else
                    {
                        secondMax = nums[i];
                    }
                }
            }

            return ((firstMax - 1) * (secondMax - 1));
        }
    }
}
