using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3827
    {
        ////(3827.) Count Monobit Integers (EASY)
        public int CountMonobit(int n)
        {
            if(n == 0)
            {
                return 1;
            }

            int count = 2;
            int sum = 1;
            int pow = 1;

            while(true)
            {
                sum += (int)Math.Pow(2, pow++);
                if (sum <= n)
                    count++;
                else
                    break;
            }

            return count;
        }
    }
}
