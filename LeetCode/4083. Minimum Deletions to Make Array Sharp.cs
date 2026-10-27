using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4083
    {
        ////(4083.) Minimum Deletions to Make Array Sharp (EASY)
        public int MinDeletions(int[] nums)
        {
            int minDeletions = 0;

            for (int index = 0; index < nums.Length-1; index++)
            {
                if ((nums[index] ^ nums[index+1]) == 0)
                    minDeletions++;
            }

            return minDeletions;
        }
    }
}
