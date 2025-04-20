using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_905
    {
        ////(905.) Sort Array By Parity (EASY)
        public int[] SortArrayByParity(int[] nums)
        {
            int length = nums.Length;
            int howManyEvenNumbers = 0; 

            for (int i = 0; i < length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    int tempValue = nums[howManyEvenNumbers];
                    nums[howManyEvenNumbers] = nums[i];
                    nums[i] = tempValue;
                    howManyEvenNumbers++;
                } 
            }


            return nums;
        }
    }
}
