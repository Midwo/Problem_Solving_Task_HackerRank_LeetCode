using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1025
    {
        ////(1025.) Divisor Game (EASY)
        public bool DivisorGame(int n)
        {
            bool AliceWin = false;
            bool outLoop = false;
            int x = 1;

            while (n > 1)
            {
                while (x < n)
                {
                    if(n % x == 0)
                    {
                        if (AliceWin) 
                        {
                            AliceWin = false;
                        }
                        else
                        {
                            AliceWin = true;
                        }
                        n -= x;
                        break;
                    }
                    x++;
                }
            }

            return AliceWin;
        }
    }
}
