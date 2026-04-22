using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0118
    {
        ////118. Chocolate Feast (EASY)
        public int chocolateFeast(int n, int c, int m)
        {
            ////Solution 1 (New)
            int eaten = n / c;
            int wrappers = eaten;

            while(wrappers >= m)
            {
                int currEaten = wrappers / m;
                wrappers = wrappers % m;
                wrappers += currEaten;
                eaten += currEaten;
            }

            return eaten;


            ////Solution 2 (Old)
            //bool endloop = true;

            //int intHowManyICanBuyBars = n / c;
            //int intcoupon = intHowManyICanBuyBars;
            //do
            //{
            //    intHowManyICanBuyBars = intHowManyICanBuyBars + intcoupon / m;
            //    intcoupon = intcoupon % m + intcoupon / m;

            //    if (m > intcoupon)
            //    {
            //        endloop = false;
            //    }
            //} while (endloop);

            //return intHowManyICanBuyBars;
        }
    }
}
