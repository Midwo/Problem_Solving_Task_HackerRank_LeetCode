using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3622
    {
        ////(3622.) Check Divisibility by Digit Sum and Product (EASY)
        public bool CheckDivisibility(int n)
        {
            ////0ms, Beats: 100.00%
            
            int copyN = n;
            int digitSum = 0;
            int digitProduct = 1;

            while(copyN != 0)
            {
                int temp = copyN % 10;
                digitSum += temp;
                digitProduct *= temp;
                copyN /= 10;
            }

            if(n % (digitProduct+digitSum) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
