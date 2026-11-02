using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4000
    {
        ////(4000.) Largest Integer With Given Digit Sum (EASY)
        public int LargestInteger(int n, int s)
        {
            int largestInteger = 0;

            for (int i = 0; i < n; i++)
            {
                if (s >= 9)
                {
                    largestInteger = largestInteger * 10 + 9;
                    s -= 9;
                }
                else
                {
                    largestInteger = largestInteger * 10 + s;
                    s = 0;
                }
            }

            return s == 0? largestInteger : -1;
        }
    }
}
