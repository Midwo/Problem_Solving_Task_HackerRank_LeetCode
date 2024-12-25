using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class LeetCodeAll
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] printOutput = [0];
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        printOutput = [i, j];
                        break;
                    }
                }
            }
            return printOutput;
        }
    }
}
