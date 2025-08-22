using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1365
    {
        ////(1365.) How Many Numbers Are Smaller Than the Current Number (EASY)
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int length = nums.Length;

            for (int i = 0; i < length; i++) 
            {
                int count = 0;
                int currValue = nums[i];
                for (int j = 0; j < length; j++)
                {
                    if(currValue > nums[j])
                    {
                        count++;
                    }
                }
                result[i] = count;
            }

            return result;
        }
    }
}
