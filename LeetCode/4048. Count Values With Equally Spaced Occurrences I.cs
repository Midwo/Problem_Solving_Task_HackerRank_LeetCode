using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4048
    {
        ////(4048.) Count Values With Equally Spaced Occurrences I (EASY)
        public int CountSpecialIntegers(int[] nums)
        {
            int result = 0;
            int[] count = new int[101];
            int[,] valueAndindexes = new int[101,3];

            for (int index = 0; index < nums.Length; index++) 
            { 
                int currValue = nums[index];
                int currCount = count[currValue];

                if (currCount < 3)
                {
                    valueAndindexes[currValue, currCount] = index;
                }

                count[currValue]++;
            }

            for (int value = 1; value < 101; value++)
            {
                if (count[value] == 3 && valueAndindexes[value,1] - valueAndindexes[value,0] == valueAndindexes[value,2] - valueAndindexes[value, 1])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
