using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1015
    {
        ////(1015.) Smallest Integer Divisible by K (MEDIUM)
        public int SmallestRepunitDivByK(int k)
        {
            if(k % 5 == 0 || k % 2 == 0)
            {
                return -1;
            }

            int actSum = 1 % k;
            int length = 1;

            while (actSum != 0)
            {
                actSum =  (actSum*10+1) % k;
                length++;
            }

            return length;
        }
    }
}
