using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3222
    {
        ////(3222.) Find the Winning Player in Coin Game (EASY)
        public string WinningPlayer(int x, int y)
        {
            y /= 4;
            x = x > y ? y : x;

            if ((x & 1) == 1)
            {
                return "Alice";
            }
            return "Bob";
        }
    }
}
