using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0038
    {
        ////38. Between Two Sets (EASY)
        public int getTotalX(List<int> a, List<int> b)
        {
            int maxA = a.Max();
            int minB = b.Min();
            int count = 0;

            for (int num = maxA; num <= minB; num++)
            {
                bool isFactorA = true;
                bool isFactorB = true;
                foreach (var i in a)
                {
                    if (num % i != 0)
                    {
                        isFactorA = false;
                    }
                }
                foreach (var i in b)
                {
                    if (i % num != 0)
                    {
                        isFactorB = false;
                    }
                }
                if (isFactorA && isFactorB)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
