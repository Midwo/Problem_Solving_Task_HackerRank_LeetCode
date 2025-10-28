using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2057
    {
        ////(2057.) Smallest Index With Equal Value (EASY)
        public int SmallestEqual(int[] nums)
        {
            ////0ms, Beats: 100.00%
            
            for (int i = 0; i < nums.Length; i++) 
            { 
                if (i % 10 == nums[i])
                {
                    return i;
                }          
            }
            return -1;
        }
    }
}
