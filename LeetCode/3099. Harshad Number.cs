using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3099
    {
        ////(3099.) Harshad Number (EASY)
        public int SumOfTheDigitsOfHarshadNumber(int x)
        {
            // 0ms, Beats: 100.00%

            int sum = 0;
            int copyX = x;

            while (copyX != 0)
            {
                sum += copyX % 10;
                copyX = copyX / 10;
            }
            if (x % sum != 0)
            {
                return -1;
            }
           
            return sum;
        }
    }
}
