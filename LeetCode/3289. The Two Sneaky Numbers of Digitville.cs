using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3289
    {
        ////(3289.) The Two Sneaky Numbers of Digitville (EASY)
        public int[] GetSneakyNumbers(int[] nums)
        {
            HashSet<int> fromNums = new HashSet<int>();
            int a = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!fromNums.Add(nums[i]))
                {
                    if (a == -1)
                    {
                        a = nums[i];
                    }
                    else
                    {
                        return new int[2] { a, nums[i] };
                    }
                }

            }

            return nums;
        }
    }
}
