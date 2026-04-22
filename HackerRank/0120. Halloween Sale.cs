using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0120
    {
        ////120. Halloween Sale (EASY)
        public int howManyGames(int p, int d, int m, int s)
        {
            ////Solution 1 (New - Better)
            int howManyGames = 0;
            while(s >= m && p <= s)
            {
                s -= p;
                p -= d;
                p = p > m ? p : m;
                howManyGames++;
            }

            return howManyGames;

            ////Solution 2 (Old - Poor)
            //bool done = true;

            //int howManyCanBuy = 0;
            //int sum = 0;
            //int nextValuePrice = 0;
            //bool firstPrice = true;

            //do
            //{
            //    if (firstPrice)
            //    {
            //        firstPrice = false;
            //        if (s >= p)
            //        {
            //            sum = p;
            //            nextValuePrice = p;
            //            howManyCanBuy++;
            //        }
            //        else
            //        {
            //            howManyCanBuy = 0;
            //            done = false;
            //        }
            //    }
            //    else
            //    {
            //        nextValuePrice = nextValuePrice - d;
            //        if (nextValuePrice <= m)
            //        {
            //            nextValuePrice = m;
            //        }
            //        if (s >= sum + nextValuePrice)
            //        {
            //            sum = sum + nextValuePrice;
            //            howManyCanBuy++;
            //        }
            //        else
            //        {
            //            done = false;
            //        }
            //    }

            //} while (done);
            //return howManyCanBuy;

        }
    }
}
