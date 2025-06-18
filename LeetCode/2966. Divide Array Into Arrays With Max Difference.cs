using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2966
    {
        ////(2966.) Divide Array Into Arrays With Max Difference (MEDIUM)
        public int[][] DivideArray(int[] nums, int k)
        {
            int length = nums.Length;
            int[][] result = new int[length/3][];
            bool canBeCreated = true;
            Array.Sort(nums);
            int indexPermutation = 0;
            for (int i = 2; i < length; i += 3)
            {
                if (nums[i] - nums[i-2] > k)
                {
                    canBeCreated = false;
                    break;
                }
                result[indexPermutation] = new int[3] { nums[i-2], nums[i-1], nums[i] };
                indexPermutation++;
            }

            if (canBeCreated) 
            {
                return result;
            }
            else
            {
                return new int[][] {};
            }
        }
    }
}
