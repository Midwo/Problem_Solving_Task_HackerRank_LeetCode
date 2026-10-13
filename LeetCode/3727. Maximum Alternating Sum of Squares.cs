using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3727
    {
        ////(3727.) Maximum Alternating Sum of Squares (MEDIUM)
        public long MaxAlternatingSum(int[] nums)
        {
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);

            long result = 0;

            bool statusMinus = false;
            int index = 0;
            int counter = 0;
            
            while(counter < length)
            {
                if (statusMinus)
                {
                    result -= nums[index];
                    statusMinus = false;
                    index++;
                }
                else
                {
                    result += nums[length - index - 1];
                    statusMinus = true;
                }
                counter++;
            }

            return result;
        }
    }
}
