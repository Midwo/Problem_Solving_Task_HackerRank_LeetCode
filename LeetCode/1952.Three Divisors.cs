using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1952
    {
        ////(1952.) Three Divisors (EASY)
        public bool IsThree(int n)
        {
            //Solution #1
            int countPositiveDivisors = 2;

            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    countPositiveDivisors++;
                    if (countPositiveDivisors > 3)
                    {
                        return false;
                    }
                }
            }

            if (countPositiveDivisors == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

            ////Solution #2
            //int countPositiveDivisors = 0;

            //for (int i = 1; i <= n; i++) 
            //{
            //    if (n % i == 0)
            //    {
            //        countPositiveDivisors++;
            //        if (countPositiveDivisors > 3)
            //        {
            //            return false;
            //        }
            //    }
            //}

            //if (countPositiveDivisors == 3)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
