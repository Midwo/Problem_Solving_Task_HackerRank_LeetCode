using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1688
    {
        ////(1688.) Count of Matches in Tournament (EASY)
        public int NumberOfMatches(int n)
        {
            int result = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    result += n;
                }
                else
                {
                    n /= 2;
                    result += n;
                    n++;
                }
            }

            return result;
        }
    }
}
