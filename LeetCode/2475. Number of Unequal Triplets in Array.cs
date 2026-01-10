using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2475
    {
        ////(2475.) Number of Unequal Triplets in Array (EASY)
        public int UnequalTriplets(int[] nums)
        {
            int countUnequalTriplets = 0;
            int length = nums.Length;

            for (int indexNums1 = 0; indexNums1 < length-2; indexNums1++)
            {
                int firstValue = nums[indexNums1];
                for (int indexNums2 = indexNums1+1; indexNums2 < length-1; indexNums2++)
                {
                    int secondValue = nums[indexNums2];
                    if (firstValue != secondValue)
                    {
                        for (int indexNums3 = indexNums2+1; indexNums3 < length; indexNums3++)
                        {
                            int thirdValue = nums[indexNums3];
                            if (secondValue != thirdValue && thirdValue != firstValue)
                            {
                                countUnequalTriplets++;
                            }
                        } 
                    }
                }
            }
            return countUnequalTriplets;
        }
    }
}
