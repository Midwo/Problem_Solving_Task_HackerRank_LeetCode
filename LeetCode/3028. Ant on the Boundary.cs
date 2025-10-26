using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3028
    {
        ////(3028.) Ant on the Boundary (EASY)
        public int ReturnToBoundaryCount(int[] nums)
        {
            ////60ms, Beats: 96.00%
            int result = 0;
            int currPosition = 0;

            foreach (var item in nums)
            {
                currPosition += item;
                if(currPosition == 0)
                {
                    result++;
                }
            }

            return result; 
        }
    }
}
