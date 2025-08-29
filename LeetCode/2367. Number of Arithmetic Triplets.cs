using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2367
    {
        ////(2367.) Number of Arithmetic Triplets (EASY)
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int length = nums.Length;
            int result = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = i+1; j < length; j++)
                {
                    for (int x = j+1; x < length; x++)
                    {
                        if (nums[x] - nums[j] == diff && nums[j] - nums[i] == diff)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
