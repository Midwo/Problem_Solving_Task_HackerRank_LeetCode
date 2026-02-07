using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2303
    {
        ////(2303.) Calculate Amount Paid in Taxes (EASY)
        public double CalculateTax(int[][] brackets, int income)
        {
            double tax = 0;

            int lastUpper = brackets[0][0];

            if (income > lastUpper)
            {
                tax += lastUpper * brackets[0][1];
                income -= lastUpper;

                for (int i = 1; i < brackets.Length; i++)
                {
                    int currUpper = brackets[i][0];
                    int lastUpperMinusCurr = currUpper - lastUpper;
                    if (lastUpperMinusCurr <= income)
                    {
                        tax += lastUpperMinusCurr * brackets[i][1];
                        income -= lastUpperMinusCurr;
                    }
                    else
                    {
                        tax += income * brackets[i][1];
                        income = 0;
                    }
                    if (income == 0)
                    {
                        break;
                    }
                    lastUpper = currUpper;
                }
            }
            else
            {
                tax += income * brackets[0][1];
            }
            
            return tax/100;
        }
    }
}
