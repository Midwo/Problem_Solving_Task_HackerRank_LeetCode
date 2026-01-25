using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1984
    {
        ////(1984.) Minimum Difference Between Highest and Lowest of K Scores (EASY)
        public int MinimumDifference(int[] nums, int k)
        {
            int lenght = nums.Length;
            int minimumDifference = int.MaxValue;

            Array.Sort(nums);

            for (int i = 0; i <= lenght-k; i++)
            {
                minimumDifference = Math.Min(minimumDifference, nums[i + k - 1] - nums[i]);
            }

            return minimumDifference;            
        }
    }
}
