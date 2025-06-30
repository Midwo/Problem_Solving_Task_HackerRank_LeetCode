using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1498
    {
        ////(1498.) Number of Subsequences That Satisfy the Given Sum Condition (MEDIUM)
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);
            int length = nums.Length;
            int leftIndex = 0;
            int rightIndex = length - 1;
            int result = 0;
            const int mod = 1000000007;
            int[] array2Power = new int[length+1];
            array2Power[0] = 1;
            for (int i = 1; i <= length; ++i)
            {
                array2Power[i] = (array2Power[i - 1] * 2) % mod;
            }

            while (leftIndex <= rightIndex)
            {
                if (nums[leftIndex] + nums[rightIndex] <= target)
                {
                    result = (result + array2Power[rightIndex - leftIndex]) % mod;
                    leftIndex++;
                }
                else
                {
                    rightIndex--;
                }
                
            }

            return result;
        }
    }
}
