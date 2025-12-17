using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2980
    {
        ////(2980.) Check if Bitwise OR Has Trailing Zeros (EASY)
        public bool HasTrailingZeros(int[] nums)
        {
            int countEven = 0;

            foreach (int item in nums)
            {
                if (item % 2 == 0)
                {
                    countEven++;
                    if (countEven == 2)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
