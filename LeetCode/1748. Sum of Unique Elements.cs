using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1748
    {
        ////(1748.) Sum of Unique Elements (EASY)
        public int SumOfUnique(int[] nums)
        {
            int sumOfUnique = 0;
            int[] tableNums = new int[101];

            foreach (var item in nums)
            {
                tableNums[item]++;
                if (tableNums[item] < 2)
                {
                    sumOfUnique += item;
                }
                else if (tableNums[item] == 2)
                {
                    sumOfUnique -= item;
                }
            }

            return sumOfUnique;
        }
    }
}
