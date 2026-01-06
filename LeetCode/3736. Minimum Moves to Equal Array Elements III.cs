using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3736
    {
        ////(3736.) Minimum Moves to Equal Array Elements III (EASY)
        public int MinMoves(int[] nums)
        {
            int maxValue = nums[0];
            int sumNums = maxValue;
            int length = nums.Length;
            int currValue = 0;

            for (int indexNums = 1; indexNums < length; indexNums++) 
            { 
                currValue = nums[indexNums];
                sumNums += currValue;

                maxValue = maxValue < currValue? currValue : maxValue; 
            }

            return (length * maxValue) - sumNums; 
        }
    }
}
