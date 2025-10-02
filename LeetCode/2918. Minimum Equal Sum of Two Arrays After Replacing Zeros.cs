using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2918
    {
        ////(2918.) Minimum Equal Sum of Two Arrays After Replacing Zeros (MEDIUM)
        public long MinSum(int[] nums1, int[] nums2)
        {
            //85ms, Beasts: 93.75%
            long sumNums1 = 0;
            long sumNums2 = 0;
            int countZeroNums1 = 0;
            int countZeroNums2 = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] > 0)
                {
                    sumNums1 += nums1[i];
                }
                else
                {
                    countZeroNums1++;
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] > 0)
                {
                    sumNums2 += nums2[i];
                }
                else
                {
                    countZeroNums2++;
                }
            }

            long minSumNums1 = sumNums1 + countZeroNums1;
            long minSumNums2 = sumNums2 + countZeroNums2;

            if (minSumNums1 >= minSumNums2)
            {
                if(countZeroNums2 > 0)
                {
                    return minSumNums1;
                } else if (minSumNums1 == minSumNums2)
                {
                    return minSumNums1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (countZeroNums1 > 0)
                {
                    return minSumNums2;
                }
                else if (minSumNums1 == minSumNums2)
                {
                    return minSumNums2;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
