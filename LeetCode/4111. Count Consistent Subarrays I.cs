using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4111
    {
        ////(4111.) Count Consistent Subarrays I (EASY)
        public int CountConsistent(int[] nums)
        {
            int length = nums.Length;
            int contConsistent = length;

            for(int indexFirstValue = 0; indexFirstValue < length-1; indexFirstValue++)
            {
                int minValue = nums[indexFirstValue];
                int bitwiseAnd = minValue;

                for(int nextIndex = indexFirstValue+1; nextIndex < length; nextIndex++)
                {
                    int currValue = nums[nextIndex];
                    minValue = minValue > currValue ? currValue : minValue;
                    bitwiseAnd &= currValue;

                    if (minValue == bitwiseAnd)
                        contConsistent++;
                }
            }

            return contConsistent;
        }
    }
}
