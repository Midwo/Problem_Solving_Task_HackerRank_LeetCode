using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2180
    {
        ////(2180.) Count Integers With Even Digit Sum (EASY)
        public int CountEven(int num)
        {
            int countEven = 0;

            for (int value = 2; value <= num; value++)
            {
                int scaleValue = 0;
                int currValue = value;
                
                while(currValue != 0)
                {
                    scaleValue += currValue % 10;
                    currValue /= 10;
                }

                if ((scaleValue & 1) == 0)
                {
                    countEven++;
                }
            }

            return countEven;
        }
    }
}
