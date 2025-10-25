using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1716
    {
        ////(1716.) Calculate Money in Leetcode Bank (EASY)
        public int TotalMoney(int n)
        {
            ////0ms, Beats: 100.00%
            decimal sum = 0;

            int countFullWeek = n / 7;
            int countRemainingDays = n - (countFullWeek * 7);

            if (countFullWeek > 0)
            {
                sum = ((decimal)(28 * 2 + (countFullWeek - 1) * 7) / 2) * countFullWeek;
                countFullWeek++;
            }
            else
            {
                countFullWeek = 1;
            }
            if (countRemainingDays > 0)
            {
                sum += ((countFullWeek * 2) + (decimal)(countRemainingDays - 1) * 1) / 2 * countRemainingDays;
            }
            return (int)sum;
        }
    }
}
