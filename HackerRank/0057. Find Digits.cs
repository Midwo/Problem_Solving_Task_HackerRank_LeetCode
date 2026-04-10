using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0057
    {
        ////57. Find Digits (EASY)
        public int findDigits(int n)
        {
            int count = 0;
            int copyN = n;

            while (copyN > 0)
            {
                int temp = copyN % 10;
                copyN /= 10;
                if(temp > 0 && n % temp == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
