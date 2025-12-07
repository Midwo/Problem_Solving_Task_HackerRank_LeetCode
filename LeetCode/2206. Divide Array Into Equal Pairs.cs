using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2206
    {
        ////(2206.) Divide Array Into Equal Pairs (EASY)
        public bool DivideArray(int[] nums)
        {
            Span<int> spanNums = stackalloc int[501];

            foreach (int num in nums) 
            { 
                spanNums[num]++;
            }

            foreach (int num in spanNums)
            {
                if (num % 2 != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
