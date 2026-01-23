using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2549
    {
        ////(2549.) Count Distinct Numbers on Board (EASY)
        public int DistinctIntegers(int n)
        {
            HashSet<int> result = new HashSet<int>();

            if (n < 3)
            {
                return 1;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    int temp = i % j; 

                    if (temp == 1)
                    {
                        result.Add(i);
                    }
                }
            }


            return result.Count();
        }
    }
}
