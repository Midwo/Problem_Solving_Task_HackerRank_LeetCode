using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2574
    {
        ////(2574.) Left and Right Sum Differences (EASY)
        public int[] LeftRightDifference(int[] nums)
        {
            int[] leftSum = new int[nums.Length];
            leftSum[0] = 0;
            int[] rightSum = new int[nums.Length];
            rightSum[nums.Length - 1] = 0;


            for (int i = nums.Length-2; i >= 0; i--)
            {
                rightSum[i] = rightSum[i + 1] + nums[i + 1];
            }

            for (int i = 1; i < nums.Length; i++)
            {
                leftSum[i] = leftSum[i - 1] + nums[i-1];
                nums[i - 1] = Math.Abs(leftSum[i - 1] - rightSum[i - 1]);
            }
            nums[nums.Length - 1] = Math.Abs(leftSum[nums.Length - 1] - rightSum[nums.Length - 1]);

            return nums;
        }
    }
}
