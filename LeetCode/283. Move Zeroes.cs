using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_283
    {
        ////(283.) Move Zeroes (EASY)
        public void MoveZeroes(int[] nums)
        {
            int howLong = nums.Length-1;
            int currentNumbersOfWithoutZero = 0;
            for (int i = 0; i <= howLong; i++) 
            {
                if (nums[i] != 0)
                {
                    if (currentNumbersOfWithoutZero != i)
                    {
                        nums[currentNumbersOfWithoutZero] = nums[i];
                        nums[i] = 0;
                    } 
                    currentNumbersOfWithoutZero++;
                }
            }
            ////checking the output data
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
