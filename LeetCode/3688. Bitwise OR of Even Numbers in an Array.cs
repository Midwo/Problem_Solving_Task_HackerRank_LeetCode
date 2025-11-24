using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3688
    {
        ////(3688.) Bitwise OR of Even Numbers in an Array (EASY)
        public int EvenNumberBitwiseORs(int[] nums)
        {
            int bitwiseEvenResult = 0;

            foreach (int num in nums) 
            { 
                if(num % 2 == 0)
                {
                    bitwiseEvenResult |= num;
                }
            } 

            return bitwiseEvenResult;
        }
    }
}
