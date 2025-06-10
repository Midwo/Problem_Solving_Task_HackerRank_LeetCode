using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3151
    {
        ////(3151.) Special Array I (EASY)
        public bool IsArraySpecial(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            bool statusEven = false;

            if (nums[0] % 2 == 0)
            {
                statusEven = true;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    if (statusEven == true)
                    {
                        return false;
                    }
                    else
                    {
                        statusEven = true;
                    }
                }
                else
                {
                    if (statusEven == false)
                    {
                        return false;
                    }
                    else
                    {
                        statusEven = false;
                    }
                }
            }

            return true;
        }
    }
}
