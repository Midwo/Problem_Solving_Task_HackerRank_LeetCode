using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2535
    {
        ////(2535.) Difference Between Element Sum and Digit Sum of an Array (EASY)
        public int DifferenceOfSum(int[] nums)
        {
            int normalSum = 0;
            int digitSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                normalSum += nums[i];

                while (nums[i] > 0)
                {
                    int temp = nums[i] % 10;
                    digitSum += temp;
                    nums[i] /= 10;
                }
            }

            return Math.Abs(normalSum - digitSum);
        }
    }
}
