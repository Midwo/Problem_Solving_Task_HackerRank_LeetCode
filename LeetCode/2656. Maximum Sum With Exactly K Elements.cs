using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2656
    {
        ////(2656.) Maximum Sum With Exactly K Elements (EASY)
        public int MaximizeSum(int[] nums, int k)
        {
            int maxValue = nums[0];

            for (int i = 1; i < nums.Length; i++) 
            { 
                maxValue = maxValue < nums[i]? nums[i] : maxValue;
            }
            return (((maxValue+(maxValue + (k - 1))) )*k/2);
        }
    }
}
