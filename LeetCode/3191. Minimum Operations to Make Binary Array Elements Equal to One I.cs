using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3191
    {
        ////(3191.) Minimum Operations to Make Binary Array Elements Equal to One I (MEDIUM)
        public int MinOperations(int[] nums)
        {
            int countOperations = 0;
            int length = nums.Length;

            for (int index = 0; index < length - 2; index++)
            {
                if (nums[index] == 0)
                {
                    nums[index] = 1 - nums[index];
                    nums[index + 1] = 1 - nums[index + 1];
                    nums[index + 2] = 1 - nums[index + 2];
                    countOperations++;
                }
            }

            if (nums[length - 1] == 0 && nums[length - 2] == 0 && nums[length - 3] == 0)
            {
                return ++countOperations;
            }
            else if (nums[length - 1] == 1 && nums[length - 2] == 1 && nums[length - 3] == 1)
            {
                return countOperations;
            }

            return -1;
        }
    }
}
