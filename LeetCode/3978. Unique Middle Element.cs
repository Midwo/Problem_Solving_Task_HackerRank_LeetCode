using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3978
    {
        ////(3978.) Unique Middle Element (EASY)
        public bool IsMiddleElementUnique(int[] nums)
        {
            int length = nums.Length;
            int middleElementIndex = length / 2;
            int middleElementValue = nums[middleElementIndex];
            
            for (int index = 0; index < length; index++)
            {
                if (nums[index] == middleElementValue && index != middleElementIndex)
                    return false;
            }

            return true;
        }
    }
}
