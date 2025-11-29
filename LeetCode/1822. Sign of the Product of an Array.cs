using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1822
    {
        ////(1822.) Sign of the Product of an Array (EASY)
        public int ArraySign(int[] nums)
        {
            bool positiveValue = true;
            foreach (int item in nums) 
            {
                if (item < 0) 
                {
                    if (positiveValue)
                    {
                        positiveValue = false;
                    }
                    else
                    {
                        positiveValue = true;
                    }
                }
                else if (item == 0)
                {
                    return 0;
                }
            }

            if (positiveValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
