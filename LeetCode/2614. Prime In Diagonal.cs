using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2614
    {
        ////(2614.) Prime In Diagonal (EASY)
        public int DiagonalPrime(int[][] nums)
        {
            int rows = nums.Length;
            int maxPrimary = 0;
            int currValue = 0;

            for (int indexRow = 0; indexRow < rows; indexRow++) 
            {
                currValue = nums[indexRow][indexRow];
                if(currValue > maxPrimary && StatusPrimary(currValue))
                    maxPrimary = currValue;


                currValue = nums[indexRow][rows - 1 - indexRow];
                if (currValue > maxPrimary && StatusPrimary(currValue))
                    maxPrimary = currValue;
            }


            return maxPrimary;
        }
        private bool StatusPrimary(int currValue)
        {
            if (currValue == 1)
            {
                return false;
            }
            else if(currValue == 2 || currValue == 3)
            {
                return true;
            }

            for (int i = 2; i < Math.Sqrt(currValue) +1; i++)
            {
                if(currValue % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
