using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3046
    {
        ////(3046.) Split the Array (EASY)
        public bool IsPossibleToSplit(int[] nums)
        {
            int[] countNums = new int[101]; 

            foreach (int item in nums) 
            {
                countNums[item]++;
                if (countNums[item] > 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
