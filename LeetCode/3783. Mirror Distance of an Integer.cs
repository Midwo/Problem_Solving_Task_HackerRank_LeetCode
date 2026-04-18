using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3783
    {
        ////(3783.) Mirror Distance of an Integer (EASY)
        public int MirrorDistance(int n)
        {
            var reverseNumber = 0;
            var copyN = n;

            while(copyN > 0)
            {
                reverseNumber *= 10;
                reverseNumber += copyN % 10;
                copyN = copyN / 10;
            }

            return Math.Abs(n - reverseNumber);
        }
    }
}
