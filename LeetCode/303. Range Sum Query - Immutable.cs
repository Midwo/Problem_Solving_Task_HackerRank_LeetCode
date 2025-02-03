using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_303
    {
        ////(303.) Range Sum Query - Immutable (EASY)
        public class NumArray
        {
            List<int> numsValues;
            public NumArray(int[] nums)
            {
                numsValues = new List<int>();
                int lastValue = 0;
                for (int i = 0; i < nums.Length; i++) 
                {
                    lastValue = nums[i] + lastValue;
                    numsValues.Add(lastValue);
                }
            }
            public int SumRange(int left, int right)
            {
                if (left == 0)
                {
                    return numsValues[right];
                }
                return numsValues[right] - numsValues[left-1];
            }
        }
    }
}
