using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2443
    {
        ////(2443.) Sum of Number and Its Reverse (MEDIUM)
        public bool SumOfNumberAndReverse(int num)
        {
            if (num == 0)
                return true;

            for (int firstValue = 1; firstValue < num; firstValue++)
            {
                int secondValue = num - firstValue;
                int reverseSecondValue = 0;
                while (secondValue != 0)
                {
                    reverseSecondValue *= 10;
                    reverseSecondValue += secondValue % 10;
                    secondValue /= 10;
                }

                if (firstValue == reverseSecondValue)
                    return true;
            }

            return false;
        }
    }
}
