using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3917
    {
        ////(3917.) Count Indices With Opposite Parity (EASY)
        public int[] CountOppositeParity(int[] nums)
        {
            int countOdd = 0;
            int countEven = 0;

            int length = nums.Length;
            int[] resultTableWithOppositeParity = new int[length];

            for (int index = length - 1; index >= 0; index--) 
            {
                if (nums[index] % 2 == 0)
                {
                    resultTableWithOppositeParity[index] = countOdd;
                    countEven++;
                }
                else
                {
                    resultTableWithOppositeParity[index] = countEven;
                    countOdd++;
                }
            }

            return resultTableWithOppositeParity;
        }
    }
}
