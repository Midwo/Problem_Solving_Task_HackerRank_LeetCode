using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3315
    {
        ////(3315.) Construct the Minimum Bitwise Array II (MEDIUM)
        public int[] MinBitwiseArray(IList<int> nums)
        {
            int length = nums.Count;
            int[] ans = new int[length];

            for (int i = 0; i < length; i++)
            {
                int currValue = nums[i];
                int firstHalfValue = currValue / 2;
                int secondHalfValue = firstHalfValue + firstHalfValue == currValue ? firstHalfValue : firstHalfValue + 1;

                int andValueOperation = firstHalfValue & secondHalfValue;

                firstHalfValue += andValueOperation;

                if ((firstHalfValue | (firstHalfValue + 1)) == currValue)
                    ans[i] = firstHalfValue;
                else
                    ans[i] = -1;
            }

            return ans;
        }
    }
}
