using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1304
    {
        ////(1304.) Find N Unique Integers Sum up to Zero (EASY)
        public int[] SumZero(int n)
        {
            int[] result = new int[n];

            if (n % 2 == 1)
            {
                result[0] = 0;

                for (int i = 1; i < n; i += 2)
                {
                    result[i] = i;
                    result[i + 1] = -i;
                }
            }
            else
            {
                for (int i = 0; i < n; i += 2)
                {
                    result[i] = i+1;
                    result[i + 1] = -i-1;
                }
            }

            return result;
        }
    }
}
