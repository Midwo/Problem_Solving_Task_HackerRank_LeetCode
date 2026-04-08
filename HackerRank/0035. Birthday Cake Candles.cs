using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0035
    {
        //35. Birthday Cake Candles (EASY) 
        public int birthdayCakeCandles(List<int> candles)
        {
            int x1 = int.MinValue;
            int y1 = int.MinValue;
            foreach (var i in candles)
            {
                if (x1 == i)
                {
                    y1 += 1;
                }
                else if (x1 < i)
                {
                    x1 = i;
                    y1 = 1;
                }

            }
            return y1;
        }
    }
}
