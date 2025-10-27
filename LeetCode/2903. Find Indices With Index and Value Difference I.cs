using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2903
    {
        ////(2903.) Find Indices With Index and Value Difference I (EASY)
        public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
        {
            ////0ms, Beats: 100.00%
            
            int[] result = new int[2] { -1, -1 };
            int length = nums.Length;

            for (int i = 0; i < length; i++) 
            { 
                int tempValue = nums[i];
                for (int j = i+indexDifference; j < length; j++)
                {
                    if (Math.Abs(tempValue - nums[j]) >= valueDifference)
                    {
                        return new int[2] {i, j};
                    }
                }           
            }
                
            return result;
        }
    }
}
