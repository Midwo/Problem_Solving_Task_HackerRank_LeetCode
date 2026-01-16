using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2562
    {
        ////(2562.) Find the Array Concatenation Value (EASY)
        public long FindTheArrayConcVal(int[] nums)
        {
            long sumConcatenationValue = 0;
            int length = nums.Length;

            if ((length & 1) == 1)
            {
                for (int i = 0; i < length / 2; i++)
                {
                    sumConcatenationValue += (int.Parse(string.Concat(nums[i], nums[length - 1 - i])));
                }
                sumConcatenationValue += nums[length / 2];
            }
            else
            {
                for (int i = 0; i < length/2; i++)
                {
                    sumConcatenationValue += (int.Parse(string.Concat(nums[i],nums[length-1-i])));
                }
            }

            return sumConcatenationValue;
        }
    }
}
