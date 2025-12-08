using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1925
    {
        ////(1925.) Count Square Sum Triples (EASY)
        public int CountTriples(int n)
        {
            int countTriples = 0;
            int maxC = n * n;

            for (int i = 1; i <=n; i++)
            {
                int currA = i;
                int temp = 0;
                int currB = 1;
                while (temp <= maxC)
                {
                    temp = currB * currB + currA * currA;
                    if (temp <= maxC)
                    {
                        int sqrtTemp = (int)Math.Sqrt(temp);
                        if(sqrtTemp * sqrtTemp == temp)
                        {
                            countTriples++;
                        }
                    }
                    currB++;
                }
            } 
            return countTriples;
        }
    }
}
