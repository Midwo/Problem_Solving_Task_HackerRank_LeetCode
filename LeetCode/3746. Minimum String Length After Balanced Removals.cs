using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3746
    {
        ////(3746.) Minimum String Length After Balanced Removals (MEDIUM)
        public int MinLengthAfterRemovals(string s)
        {
            int countA = 0;
            int countB = 0;

            foreach (char c in s) 
            {
                if (c == 'a')
                    countA++;
                else
                    countB++;           
            }

            return Math.Abs(countB - countA);
        }
    }
}
