using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_209
    {
        ////(209.) Minimum Size Subarray Sum (MEDIUM)
        public int MinSubArrayLen(int target, int[] nums)
        {
            int L = 0;
            int R = 1;
            int result = int.MaxValue;
            bool end = false;

            if (nums.Length == 1)
            {
                if (nums[0] < target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            int sum = nums[L] + nums[R];

            if (nums[L] >= target || nums[R] >= target)
            {
                return 1;
            }

            while (!end)
            {
                if (sum < target)
                {
                    R++;
                    if (R == nums.Length)
                    {
                        if (result != int.MaxValue)
                        {
                            return result;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    if (nums[R] == target)
                    {
                        return 1;
                    }
                    sum += nums[R];
                }
                else
                {
                    //if (nums[R] == target)
                    //{
                    //    return 1;
                    //}
                    result = Math.Min(R - L + 1, result);
                    sum -= nums[L];
                    L++;
                }
                if (R == L)
                {
                    return Math.Min(R - L + 2, result);
                }
            }


            if (result == int.MaxValue)
            {
                return 0;
            }
            return result;
        }
    }
}
