using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4092
    {
        ////(4092.) Binary Digit Score (EASY)
        public int CalculateScore(int a, int b)
        {
            int countOneInA = 0;
            int countOneInB = 0;

            while (a != 0)
            {
                if (a % 2 == 1)
                    countOneInA++;
                a /= 2;
            }
            
            while (b != 0)
            {
                if (b % 2 == 1)
                    countOneInB++;
                b /= 2;
            }

            if (countOneInA >= countOneInB)
                return countOneInA * countOneInB;

            return countOneInB / countOneInA;
        }
    }
}
