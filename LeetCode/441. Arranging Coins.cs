using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_441
    {
        ////(441.) Arranging Coins (EASY)
        public int ArrangeCoins(int n)
        {
            int result = 0;
            int currValue = 1;
            while(n > 0)
            {
                n = n - currValue++;
                if (n > 0) { result++; }
            }
            return result;
        }
    }
}
