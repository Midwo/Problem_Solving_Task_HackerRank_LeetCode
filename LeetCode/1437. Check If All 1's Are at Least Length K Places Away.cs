using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1437
    {
        ////(1437.) Check If All 1's Are at Least Length K Places Away (EASY)
        public bool KLengthApart(int[] nums, int k)
        {
            int lastIndexOneValue = 0;
            int lengthNums = nums.Length;

            for (int i = 0; i < lengthNums; i++) 
            {
                if (nums[i] == 1)
                {
                    lastIndexOneValue = i;
                    break;
                }
            }

            for (int i = lastIndexOneValue+1; i < lengthNums; i++)
            {
                if (nums[i] == 1)
                {
                    if(lastIndexOneValue+k >= i)
                    {
                        return false;
                    }
                    lastIndexOneValue = i;
                }
            }

            return true;
        }
    }
}
