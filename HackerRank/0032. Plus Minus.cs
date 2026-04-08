using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0032
    {
        ////32. Plus Minus (EASY)       
        public void plusMinus(List<int> arr)
        {
            decimal plus = 0;
            decimal minus = 0;
            decimal zero = 0;
            decimal howmany = arr.Count();
            foreach (int item in arr)
            {
                if (item == 0)
                {
                    zero++;
                }
                else if (item > 0)
                {
                    plus++;
                }
                else
                {
                    minus++;
                }
            }
            decimal pluscount = plus / howmany;
            decimal minuscount = minus / howmany;
            decimal zerocount = zero / howmany;

            Console.WriteLine(pluscount);
            Console.WriteLine(minuscount);
            Console.WriteLine(zerocount);
        }

    }
}
