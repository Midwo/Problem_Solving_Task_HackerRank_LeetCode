using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4097
    {
        ////(4097.) Minimum Value of Merged Integers (EASY)
        public int MinMergedInteger(int[] nums)
        {
            int minValue = int.MaxValue;

            for(int index = 1; index < nums.Length; index+=2)
            {
                int mergeValueString = int.Parse(nums[index - 1].ToString() + nums[index].ToString());
                minValue = minValue > mergeValueString ? mergeValueString : minValue;
            }

            return minValue;
        }
    }
}
