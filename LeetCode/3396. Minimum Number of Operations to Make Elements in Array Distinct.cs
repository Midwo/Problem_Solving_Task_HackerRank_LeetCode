using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3396
    {
        ////(3396.) Minimum Number of Operations to Make Elements in Array Distinct (EASY)
        public int MinimumOperations(int[] nums)
        {
            int length = nums.Length;

            int[] countNumbers = new int[101];
            int indexStop = length - 1;
            
            for (; indexStop >= 0; indexStop--)
            {
                countNumbers[nums[indexStop]]++;
                if (countNumbers[nums[indexStop]] == 2)
                {
                    break;
                }
            }

            int result = (indexStop + 1) / 3;
            if (result*3 <= indexStop)
            {
                return result+1;
            }
            return result;
        }
    }
}
