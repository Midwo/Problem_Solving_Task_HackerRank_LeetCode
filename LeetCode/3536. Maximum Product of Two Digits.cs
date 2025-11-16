using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3536
    {
        ////(3536.) Maximum Product of Two Digits (EASY)
        public int MaxProduct(int n)
        {
            int maxValue = int.MinValue;
            int secondMaxValue = int.MinValue;

            while (n > 0) 
            {
                int temp = n % 10;

                if (temp > maxValue) 
                {
                    secondMaxValue = maxValue;
                    maxValue = temp;
                }
                else if (secondMaxValue < temp)
                {
                    secondMaxValue = temp;

                    if (secondMaxValue == 9)
                    {
                        return maxValue * secondMaxValue;
                    }
                }

                n /= 10;
            }

            return maxValue * secondMaxValue;
        }
    }
}
