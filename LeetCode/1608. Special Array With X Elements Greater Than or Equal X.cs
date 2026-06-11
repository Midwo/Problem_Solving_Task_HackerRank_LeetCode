using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1608
    {
        ////(1608.) Special Array With X Elements Greater Than or Equal X (EASY)
        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);
            HashSet<int> hashSet = new HashSet<int>(nums);
            int length = nums.Length;
            int maxCount = -1;
            int leftIndex = 0;

            for (int value = 0; value <= length; value++)
            {
                while (leftIndex < length && value > nums[leftIndex])
                {
                    leftIndex++;
                }  
                if (value == length - leftIndex)
                {
                    maxCount = Math.Max(maxCount, length-leftIndex);
                }
            }

            return maxCount;
        }
    }
}
