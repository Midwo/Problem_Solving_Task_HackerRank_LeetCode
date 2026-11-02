using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_462
    {
        ////(462.) Minimum Moves to Equal Array Elements II (MEDIUM)
        public int MinMoves2(int[] nums)
        {
            Array.Sort(nums);
            int median = nums[nums.Length/2];
            int countMoves = 0;

            foreach (int num in nums) 
            {
                countMoves += Math.Abs(num - median);            
            }

            return countMoves;
        }
    }
}
