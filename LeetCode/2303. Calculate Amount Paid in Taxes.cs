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

            int lastUpper = 0;

            for (int i = 0; i < brackets.Length; i++)
            {
                int currUpper = brackets[i][0];
                int taxable = Math.Min(income, currUpper - lastUpper);

                tax += taxable * brackets[i][1];
                income -= taxable;

                if (income == 0)
                {
                    break;
                }
                lastUpper = currUpper;
            }

            return tax/100;
        }
    }
}
