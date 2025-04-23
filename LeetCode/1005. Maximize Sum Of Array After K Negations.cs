using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1005
    {
        ////(1005.) Maximize Sum Of Array After K Negations (EASY)
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            int length = nums.Length;

            int index = 1;
            nums[0] *= -1;
            k--;

            if (nums[0] == 0)
            {
                return nums.Sum();
            }

            while (k != 0)
            {
                if (nums[index] < 0)
                {
                    nums[index] *= -1;
                    if (index != length - 1)
                    {
                        index++;
                    }
                }
                else if (nums[index] == 0)
                {
                    break;
                }
                else
                {
                    if (nums[index-1] >= nums[index])
                    {
                        nums[index] *= -1;
                    }
                    else
                    {
                        nums[index-1] *= -1;
                    }
                }
 
                k--;
            }

            return nums.Sum();
        }
    }
}
