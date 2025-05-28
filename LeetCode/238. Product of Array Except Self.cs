using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_238
    {
        ////(238.) Product of Array Except Self (MEDIUM)
        public int[] ProductExceptSelf(int[] nums)
        {
            int leftSum = 1;
            int rightSum = 1;
            int lengthNums = nums.Length;
            int[] leftArray = new int[lengthNums];
            int[] rightArray = new int[lengthNums];
            
            if (lengthNums > 2)
            {
                leftArray[0] = 1;
                rightArray[lengthNums - 1] = 1;
            }
            else
            {
                return new int[] { nums[1], nums[0] }; 
            }

            for (int i = 1; i < lengthNums; i++)
            {
                leftSum *= nums[i-1];
                leftArray[i] = leftSum;

                rightSum *= nums[lengthNums - i];
                rightArray[lengthNums - i-1] = rightSum;
            }

            nums[0] = rightArray[0];
            nums[lengthNums - 1] = leftArray[lengthNums - 1];

            for (int i = 1; i < lengthNums-1; i++)
            {
                nums[i] = leftArray[i] * rightArray[i];
            }

            return nums;
        }
    }
}
