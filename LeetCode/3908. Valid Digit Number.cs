using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3908
    {
        ////(3908.) Valid Digit Number (EASY)
        public bool ValidDigit(int n, int x)
        {
            int firstValueN = 0;
            bool nCostainsX = false;

            while(n != 0)
            {
                firstValueN = n % 10;
                if (firstValueN == x)
                    nCostainsX = true;
                n = n / 10;
            }

            if (firstValueN != x && nCostainsX)
                return true;

            return false;
        }
    }
}
